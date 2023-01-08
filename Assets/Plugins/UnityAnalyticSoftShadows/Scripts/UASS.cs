using UnityEngine;
using System;
using System.Linq;
using UnityEngine.Rendering;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public class UASS : MonoBehaviour
{
    const int tileSize = 32; //shadelmodel5 max numthreads is 1024
    const int maxLights = tileSize * tileSize;
    
    [Tooltip("Directional and Point lights are supported.\n\nPoint Light limitations:\n-Indirect algorithm only\n-Box shape does not cast shadows\n\nYou can add more than one UASS script to your camera to use multiple lights")]
    public new Light light;
    [Tooltip("Auto_* means it will pick between Half/Third/Quarter/Etc. based on Light Angle (recommended).\nUASS uses depth-aware-upscaling so low resolutions still look pretty good, they may look better with good antialiasing. Overkill is full resolution.")]
    public Quality quality = Quality.Auto_Balanced;
    public enum Quality { Auto_Quality, Auto_Balanced, Auto_Performance, Overkill, Half, Third, Quarter };
    [Tooltip("Direct is more expensive at very wide angles/does not fade with distance/is more puffy/capsules have a discontinuity at certain angles.\nIndirect is the original well known analytic shadows algorithm, has less self shadowing problems (when the receiver is very close to the caster).\nBoxes in indirect are direct's boxes that try to match the look of indirect's spheres and capsules by fading with distance. (Boxes are also about 2x relatively more expensive than Spheres and Capsules to calculate)")]
    public Algorithm algorithm = Algorithm.Indirect;
    public enum Algorithm { Indirect, Direct }
    [Range(10f, 180f), Tooltip("Controls the softness of the shadows. (Feel free to change at runtime)")]
    public float lightAngle = 60f;
    [Range(0f, 1f), Tooltip("Controls the visibility of the shadows.")]
    public float shadowStrength = 1f;

    [NonSerialized] public static readonly HashSet<UASSSphere> Spheres = new HashSet<UASSSphere>();
    [NonSerialized] public static readonly HashSet<UASSCapsule> Capsules = new HashSet<UASSCapsule>();
    [NonSerialized] public static readonly HashSet<UASSBox> Boxes = new HashSet<UASSBox>();

    private ComputeBuffer lightListBuffer, lightIndexBuffer, currentLightIndexBuffer;
    private RenderTexture lightsGridTex;
    [NonSerialized] public CommandBuffer buf;
    private Camera cam;
    private int prevScreenWidth, prevScreenHeight;
    private int downscale;
    private int prevDownscale;
    private Algorithm prevAlgorithm;
    private bool prevLightActive;
    private SphericalHarmonicsL2 prevSH;
    private Material material;
    private ComputeShader lightCullingCompute;

    void Reset()
    {
        if (GraphicsSettings.renderPipelineAsset == null) Debug.LogWarning("[UASS] This version of Soft Analytic Shadows requires the Universal render pipeline");
        OnValidate();
    }
    void OnValidate()
    {
        if (enabled && (!Resources.Load<Material>("UASS").shader.isSupported || !SystemInfo.supportsComputeShaders))
        {
            Debug.LogError("[UASS] UASS is not supported on your platform/hardware." + (!SystemInfo.supportsComputeShaders ? " (No ComputeShader support)" : ""));
            enabled = false;
        }
        if (light == null) light = FindObjectsOfType<Light>().FirstOrDefault(x => x.type == LightType.Directional);
        if (light == null) light = FindObjectsOfType<Light>().FirstOrDefault(x => x.type == LightType.Point);
        if (light && !(light.type == LightType.Directional || light.type == LightType.Point)) Debug.LogWarning("[UASS] Only Directional and Point lights are supported", this);
        if (light && light.type == LightType.Point) algorithm = Algorithm.Indirect;
    }
    
    void OnDisable()
    {
        Cleanup();
        if (material != null) DestroyImmediate(material);
        if (lightCullingCompute != null) DestroyImmediate(lightCullingCompute);
    }

    struct LightData
    {
        public Vector3 boundingConePos;
        public float boundingConeLength;
        public float boundingConeRadius;
        public float boundingConeBackadd;
        public Matrix4x4 mat;
        public Vector3 minMaxDist;
    }
    static Mesh s_Triangle;
    static Mesh Triangle
    {
        get
        {
            if (s_Triangle != null) return s_Triangle;
            s_Triangle = new Mesh
            {
                vertices = new Vector3[] {
                    new Vector3(-1f, -1f, 0f),
                    new Vector3(-1f,  3f, 0f),
                    new Vector3( 3f, -1f, 0f)
                },
                triangles = new int[] { 0, 1, 2 },
            };
            s_Triangle.UploadMeshData(true);
            return s_Triangle;
        }
    }
    void OnResolutionOrSettingsChange()
    {
        if (!light || !light.isActiveAndEnabled) return;

        int numFrustumsX = Mathf.CeilToInt(cam.pixelWidth / (float)tileSize);
        int numFrustumsY = Mathf.CeilToInt(cam.pixelHeight / (float)tileSize);
        int numTotalFrustrums = numFrustumsX * numFrustumsY;

        //print(System.Runtime.InteropServices.Marshal.SizeOf(typeof(LightData)));
        lightListBuffer = new ComputeBuffer(maxLights, 100);
        lightIndexBuffer = new ComputeBuffer(maxLights * numTotalFrustrums, 4);
        currentLightIndexBuffer = new ComputeBuffer(1, 4);

        lightsGridTex =
            new RenderTexture(numFrustumsX, numFrustumsY, 0, RenderTextureFormat.RGInt, RenderTextureReadWrite.Linear) { filterMode = FilterMode.Point, enableRandomWrite = true };
        lightsGridTex.Create();

        lightCullingCompute.SetTexture(0, "lightsGrid", lightsGridTex);
        lightCullingCompute.SetBuffer(0, "lights", lightListBuffer);

        buf = new CommandBuffer { name = "Analytic Soft Shadows" };
        buf.SetComputeTextureParam(lightCullingCompute, 0, "depthBuffer", Shader.PropertyToID("_CameraDepthTexture"));
        buf.SetComputeBufferParam(lightCullingCompute, 0, "currentIndex", currentLightIndexBuffer);
        buf.SetComputeBufferParam(lightCullingCompute, 0, "lightsIndexBuffer", lightIndexBuffer);
        buf.SetComputeVectorParam(lightCullingCompute, "data", new Vector4(1.0f / cam.pixelWidth, 1.0f / cam.pixelHeight, numFrustumsX, numFrustumsY));
        buf.DispatchCompute(lightCullingCompute, 0, numFrustumsX, numFrustumsY, 1);


        buf.SetGlobalTexture("lightsGrid", lightsGridTex);
        buf.SetGlobalBuffer("lightsIndexBuffer", lightIndexBuffer);
        buf.SetGlobalBuffer("lights", lightListBuffer);


        int lowRes = Shader.PropertyToID("_Temp1");
        buf.GetTemporaryRT(lowRes, Mathf.CeilToInt(cam.pixelWidth / (float)(downscale + 1)), Mathf.CeilToInt(cam.pixelHeight / (float)(downscale + 1)), 0, FilterMode.Bilinear);

        buf.SetRenderTarget(lowRes, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store);
        buf.DrawMesh(Triangle, Matrix4x4.identity, material, submeshIndex: 0, shaderPass: 0);

        //
        int _analyicShadowsTexture = Shader.PropertyToID("_UASSTexture");
        //

        buf.SetRenderTarget(_analyicShadowsTexture);
        buf.SetGlobalTexture("_SourceTex", lowRes);
        buf.DrawMesh(Triangle, Matrix4x4.identity, material, submeshIndex: 0, shaderPass: 1);

        buf.ReleaseTemporaryRT(lowRes);

        cam.AddCommandBuffer(CameraEvent.BeforeLighting, buf);
    }
    void Cleanup()
    {
        /*if (buf != null) { buf.Clear(); buf.Dispose(); }*/
        if (cam != null && buf != null) { cam.RemoveCommandBuffer(CameraEvent.BeforeLighting, buf);/* buf.Dispose();*/ }
        if (lightListBuffer != null) lightListBuffer.Dispose();
        if (lightIndexBuffer != null) lightIndexBuffer.Dispose();
        if (currentLightIndexBuffer != null) currentLightIndexBuffer.Dispose();
        if (lightsGridTex != null) DestroyImmediate(lightsGridTex);
    }

    public void OnPreRenderScriptablePipeline()
    {
        if (material == null) material = new Material(Resources.Load<Material>("UASS")) { hideFlags = HideFlags.HideAndDontSave };
        if (lightCullingCompute == null)
        {
            lightCullingCompute = Instantiate(Resources.Load<ComputeShader>("UASSCulling"));
            lightCullingCompute.hideFlags = HideFlags.HideAndDontSave;//important for scene view
        }
        if (cam == null) cam = GetComponent<Camera>();
        if (light && light.type == LightType.Point) algorithm = Algorithm.Indirect;


        downscale = (int)quality < 3 ? Mathf.Max(1, Mathf.RoundToInt(Mathf.Lerp(new float[] { 0f, 0f, 1f }[(int)quality],
            algorithm == Algorithm.Direct ? new float[] { 3f, 6f, 12f }[(int)quality] : new float[] { 2f, 4f, 8f }[(int)quality], lightAngle / 180f))) : (int)quality - 3;
        if (lightsGridTex == null
            || cam.pixelWidth != prevScreenWidth || cam.pixelHeight != prevScreenHeight || downscale != prevDownscale || algorithm != prevAlgorithm
            || !light || light.isActiveAndEnabled != prevLightActive)
        {
            prevScreenWidth = cam.pixelWidth;
            prevScreenHeight = cam.pixelHeight;
            prevDownscale = downscale;
            prevAlgorithm = algorithm;
            prevLightActive = light && light.isActiveAndEnabled;

            Cleanup();
            OnResolutionOrSettingsChange();
        }

        if (!light || !light.isActiveAndEnabled) return;
        float k = 180f / lightAngle;

        lightCullingCompute.SetMatrix("InverseProjection", GL.GetGPUProjectionMatrix(cam.projectionMatrix, false).inverse);
        lightCullingCompute.SetMatrix("WorldToViewMatrix", cam.worldToCameraMatrix);
        lightCullingCompute.SetMatrix("ViewToWorldMatrix", cam.cameraToWorldMatrix);
        Vector4 _Light = light.type == LightType.Point ? light.transform.position : -light.transform.forward;
        _Light.w = light.type == LightType.Point ? light.range + 0.001f : 0;
        lightCullingCompute.SetVector("_Light", _Light);
        lightCullingCompute.SetFloat("LightAngle", Mathf.Lerp(0f, Mathf.PI / 2f, 180f / k / 180f));
        lightCullingCompute.SetBool("IndirectAlgorithm", algorithm == Algorithm.Indirect);
        currentLightIndexBuffer.SetData(new uint[1] { 0 });

        material.SetMatrix("_InverseViewMatrix", cam.worldToCameraMatrix.inverse);
        material.SetFloat("_K", k);
        material.SetVector("_Light", _Light);
        material.SetFloat("_ShadowStrength", 1.0f - shadowStrength);
        if (algorithm == Algorithm.Indirect)
            material.EnableKeyword("INDIRECT_ALGO");
        else
            material.DisableKeyword("INDIRECT_ALGO");

        bool noCpuCulling = light.type == LightType.Point;
        var lightDir = light.transform.forward;
        Vector4[] frustumPlanes = GeometryUtility.CalculateFrustumPlanes(cam).Select(x => new Vector4(x.normal.x, x.normal.y, x.normal.z, x.distance)).ToArray();
        float boundingConeRadius = 10f * (Mathf.Lerp(5.28f, 7f, Mathf.InverseLerp(2.5f, 1f, k)) / k) * Mathf.Deg2Rad;
        Vector3[] furthestPointDirections = frustumPlanes.Select(x => Vector3.Cross(Vector3.Cross(x, lightDir), lightDir) * boundingConeRadius).ToArray();

        LightData[] lights = new LightData[maxLights];
        int index = 0;
        foreach (UASSSphere sphereObj in Spheres.Where(x => x)/*.OrderBy(x => Vector3.Distance(cam.transform.position, x.transform.TransformPoint(x.center)))*/)
        {
            Vector3 center = sphereObj.transform.TransformPoint(sphereObj.center);
            float radius = sphereObj.radius * MaxVector(AbsVector(sphereObj.transform.lossyScale));
            radius *= algorithm == Algorithm.Indirect ? 2f : 1;

            float max = Mathf.Max(0.1f, radius);
            float backadd = k * max;
            Vector3 boundingConePos = sphereObj.transform.TransformPoint(sphereObj.center) - lightDir * backadd;
            float boundingConeLength = algorithm == Algorithm.Indirect ? (k * 5.775f/*2.8875f*/ * max + backadd + max) : 1000f;
            float boundingConeBackadd = backadd - max;
            if (noCpuCulling || CappedConeInsideFrustum(boundingConePos, lightDir, boundingConeLength, boundingConeRadius, boundingConeBackadd, frustumPlanes, furthestPointDirections))
            {
                lights[index++] = new LightData()
                {
                    boundingConePos = boundingConePos,
                    boundingConeLength = boundingConeLength,
                    boundingConeRadius = boundingConeRadius * 1.5f,
                    boundingConeBackadd = boundingConeBackadd,

                    mat = new Matrix4x4(
                        new Vector4(center.x, center.y, center.z, radius - 0.01f),
                        Vector4.zero,
                        Vector4.zero,
                        new Vector4(0, 0, 0, 1)),
                    minMaxDist = new Vector3(sphereObj.Bias01, sphereObj.maxDistance, 0)
                };
                if (index == maxLights) break;
            }
        }
        foreach (UASSCapsule capsuleObj in Capsules.Where(x => x)/*.OrderBy(x => Vector3.Distance(cam.transform.position, x.transform.TransformPoint(x.center)))*/)
        {
            Vector3 begin, end, center;
            float radius, height;
            ToWorldSpaceCapsule(capsuleObj, out begin, out end, out radius, out center, out height);
            radius *= algorithm == Algorithm.Indirect ? 2f : 1;

            float max = Mathf.Max(0.1f, Mathf.Max(height / 2f, radius) * (algorithm == Algorithm.Indirect ? 2f : 1.1f));
            float backadd = k * max;
            Vector3 boundingConePos = capsuleObj.transform.TransformPoint(capsuleObj.center) - lightDir * backadd;
            float boundingConeLength = algorithm == Algorithm.Indirect ? (k * /*5.775f*/2.8875f * max + backadd + max) : 1000f;
            float boundingConeBackadd = algorithm == Algorithm.Indirect ? backadd - max * 2f : backadd - max;
            float coneRadiusMul = algorithm == Algorithm.Indirect ? 3f : 1f;
            if (noCpuCulling || CappedConeInsideFrustum(boundingConePos, lightDir, boundingConeLength, boundingConeRadius * coneRadiusMul, boundingConeBackadd, frustumPlanes, furthestPointDirections))
            {
                lights[index++] = new LightData()
                {
                    boundingConePos = boundingConePos,
                    boundingConeLength = boundingConeLength,
                    boundingConeRadius = boundingConeRadius * coneRadiusMul,
                    boundingConeBackadd = boundingConeBackadd,

                    mat = new Matrix4x4(
                        new Vector4(begin.x, begin.y, begin.z, radius - 0.001f),
                        new Vector4(end.x, end.y, end.z, 0),
                        Vector4.zero,
                        new Vector4(0, 0, 0, 2)),
                    minMaxDist = new Vector3(capsuleObj.Bias01, capsuleObj.maxDistance, 0)
                };
                if (index == maxLights) break;
            }
        }
        if (light.type != LightType.Point)
        {
            foreach (UASSBox boxObj in Boxes.Where(x => x)/*.OrderBy(x => Vector3.Distance(cam.transform.position, x.transform.TransformPoint(x.center)))*/)
            {
                //TODO: this could be improved with Indirect
                float max = MaxVector(AbsVector(Vector3.Scale(boxObj.size, boxObj.transform.lossyScale)));
                float backadd = k * Mathf.Max(0.1f, max);
                Vector3 boundingConePos = boxObj.transform.TransformPoint(boxObj.center) - lightDir * backadd;
                float boundingConeLength = algorithm == Algorithm.Indirect ? /**/boxObj.fadeDistance * Mathf.Max(k * k, 10)/**/ + backadd : 1000f;
                float boundingConeBackadd = backadd - max;
                if (noCpuCulling || CappedConeInsideFrustum(boundingConePos, lightDir, boundingConeLength, boundingConeRadius, boundingConeBackadd, frustumPlanes, furthestPointDirections))
                {
                    var matrix = Matrix4x4.TRS(boxObj.transform.TransformPoint(boxObj.center), boxObj.transform.rotation, Vector3.one).inverse;
                    Vector4 v = AbsVector(Vector3.Scale(boxObj.size, boxObj.transform.lossyScale) / 2f - (Vector3.one * 0.001f));
                    v.w = boxObj.cheap ? 4 : 3;
                    matrix.SetRow(3, v);

                    lights[index++] = new LightData()
                    {
                        boundingConePos = boundingConePos,
                        boundingConeLength = boundingConeLength,
                        boundingConeRadius = boundingConeRadius,
                        boundingConeBackadd = boundingConeBackadd,

                        mat = matrix,
                        minMaxDist = new Vector3(boxObj.Bias01, boxObj.fadeDistance, 0)
                    };
                    if (index == maxLights) break;
                }
            }
        }

        //if (index == maxLights) Debug.LogWarning("[UASS] Shadowcaster objects limit reached", this);
        for (int i = index; i < maxLights; ++i) lights[i] = new LightData();//zero-initialize the remaining elements

        lightListBuffer.SetData(lights);
    }


    void ToWorldSpaceCapsule(UASSCapsule capsule, out Vector3 point0, out Vector3 point1, out float radius, out Vector3 center, out float height)
    {
        center = capsule.transform.TransformPoint(capsule.center);
        radius = 0f;
        height = 0f;
        Vector3 lossyScale = capsule.transform.lossyScale;
        Vector3 dir = Vector3.zero;

        switch ((int)capsule.direction)
        {
            case 0: // x
                radius = Mathf.Max(Mathf.Abs(lossyScale.y), Mathf.Abs(lossyScale.z)) * capsule.radius;
                height = Mathf.Abs(lossyScale.x) * capsule.height;
                dir = capsule.transform.TransformDirection(Vector3.right);
                break;
            case 1: // y
                radius = Mathf.Max(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.z)) * capsule.radius;
                height = Mathf.Abs(lossyScale.y) * capsule.height;
                dir = capsule.transform.TransformDirection(Vector3.up);
                break;
            case 2: // z
                radius = Mathf.Max(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.y)) * capsule.radius;
                height = Mathf.Abs(lossyScale.z) * capsule.height;
                dir = capsule.transform.TransformDirection(Vector3.forward);
                break;
        }

        if (height < radius * 2f)//
        {
            //dir = Vector3.zero;
            height = radius * 2f + 0.001f;
        }

        point0 = center + dir * (height * 0.5f - radius);
        point1 = center - dir * (height * 0.5f - radius);
    }
    Vector3 AbsVector(Vector3 vec) { return new Vector3(Mathf.Abs(vec.x), Mathf.Abs(vec.y), Mathf.Abs(vec.z)); }
    float MaxVector(Vector3 vec) { return Mathf.Max(vec.x, vec.y, vec.z); }

    bool CappedConeInsideFrustum(Vector3 origin, Vector3 forward, float size, float angle, float backadd, Vector4[] frustumPlanes, Vector3[] furthestPointDirectionsTimesAngle)
    {
        for (int i = 0; i < 6; i++)
        {
            Vector3 fpoc = origin + forward * size - furthestPointDirectionsTimesAngle[i] * size;
            Vector3 fpoc2 = origin + forward * backadd - furthestPointDirectionsTimesAngle[i] * backadd;

            if (Vector4.Dot(frustumPlanes[i], new Vector4(fpoc2.x, fpoc2.y, fpoc2.z, 1.0f)) < 0f && Vector4.Dot(frustumPlanes[i], new Vector4(fpoc.x, fpoc.y, fpoc.z, 1.0f)) < 0f)
            {
                return false;
            }
        }
        return true;
    }

    static void SetGlobalVectorsSHCoefficients(CommandBuffer cmd)
    {
        SphericalHarmonicsL2 sh;
        LightProbes.GetInterpolatedProbe(Vector3.positiveInfinity, null, out sh);//add n blendmode
        // Constant + Linear
        for (var i = 0; i < 3; i++)
            cmd.SetGlobalVector(_idSHA[i], new Vector4(
                sh[i, 3], sh[i, 1], sh[i, 2], sh[i, 0] - sh[i, 6]
            ));
        // Quadratic polynomials
        for (var i = 0; i < 3; i++)
            cmd.SetGlobalVector(_idSHB[i], new Vector4(
                sh[i, 4], sh[i, 6], sh[i, 5] * 3, sh[i, 7]
            ));
        // Final quadratic polynomial
        cmd.SetGlobalVector(_idSHC, new Vector4(
            sh[0, 8], sh[2, 8], sh[1, 8], 1
        ));
    }
    static int[] _idSHA = {
            Shader.PropertyToID("unity_SHAr"),
            Shader.PropertyToID("unity_SHAg"),
            Shader.PropertyToID("unity_SHAb")
        };
    static int[] _idSHB = {
            Shader.PropertyToID("unity_SHBr"),
            Shader.PropertyToID("unity_SHBg"),
            Shader.PropertyToID("unity_SHBb")
        };
    static int _idSHC = Shader.PropertyToID("unity_SHC");

    Color ShadeSH9(SphericalHarmonicsL2 cs, Vector3 normal)
    {
        const float c0 = .2820948f;
        const float c1 = .325735f;
        const float c2 = .2731371f;
        const float c3 = .15769578f;
        const float c4 = .1365685f;

        float x = normal.x;
        float y = normal.y;
        float z = normal.z;

        float x1 = x * y;
        float y1 = y * z;
        float z1 = z * z;
        float w1 = z * x;

        float c = x * x - y * y;

        float r = c1 * (cs[0, 2] * z - cs[0, 3] * x - cs[0, 1] * y) + c0 * cs[0, 0] + c2 * (cs[0, 4] * x1 - cs[0, 5] * y1 - cs[0, 7] * w1) + c3 * cs[0, 6] * z1 + c * c4 * cs[0, 8];
        float g = c1 * (cs[1, 2] * z - cs[1, 3] * x - cs[1, 1] * y) + c0 * cs[1, 0] + c2 * (cs[1, 4] * x1 - cs[1, 5] * y1 - cs[1, 7] * w1) + c3 * cs[1, 6] * z1 + c * c4 * cs[1, 8];
        float b = c1 * (cs[2, 2] * z - cs[2, 3] * x - cs[2, 1] * y) + c0 * cs[2, 0] + c2 * (cs[2, 4] * x1 - cs[2, 5] * y1 - cs[2, 7] * w1) + c3 * cs[2, 6] * z1 + c * c4 * cs[2, 8];

        return new Color(r, g, b);
    }


    #region UnityEditor
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Tools/UASS/Replace all selected Colliders with UASS components", isValidateFunction: true)]
    [UnityEditor.MenuItem("Tools/UASS/Add UASS components next to all selected Colliders", isValidateFunction: true)]
    static bool AreAnyCollidersSelected() { return UnityEditor.Selection.GetTransforms(UnityEditor.SelectionMode.ExcludePrefab).Any(x => x.GetComponent<Collider>()); }

    [UnityEditor.MenuItem("Tools/UASS/Replace all selected Colliders with UASS components")] static void ReplaceCollidersWithCasters() { DoColliders(true); }
    [UnityEditor.MenuItem("Tools/UASS/Add UASS components next to all selected Colliders")] static void AddCastersNextToColliders() { DoColliders(false); }

    static void DoColliders(bool replace)
    {
        var logNames = new List<string>();
        foreach (var t in UnityEditor.Selection.GetTransforms(UnityEditor.SelectionMode.ExcludePrefab | UnityEditor.SelectionMode.Editable))
        {
            foreach (var col in t.GetComponents<SphereCollider>().Where(x => x.enabled || !replace))
            {
                UnityEditor.Undo.AddComponent<UASSSphere>(t.gameObject).CopyParameters(col);
                UnityEditor.Undo.RecordObject(col, "Modify Colliders");
                if (replace) col.enabled = false;
                logNames.Add(col.name);
            }
            foreach (var col in t.GetComponents<CapsuleCollider>().Where(x => x.enabled || !replace))
            {
                UnityEditor.Undo.AddComponent<UASSCapsule>(t.gameObject).CopyParameters(col);
                UnityEditor.Undo.RecordObject(col, "Modify Colliders");
                if (replace) col.enabled = false;
                logNames.Add(col.name);
            }
            foreach (var col in t.GetComponents<BoxCollider>().Where(x => x.enabled || !replace))
            {
                UnityEditor.Undo.AddComponent<UASSBox>(t.gameObject).CopyParameters(col);
                UnityEditor.Undo.RecordObject(col, "Modify Colliders");
                if (replace) col.enabled = false;
                logNames.Add(col.name);
            }
        }
        if (replace) Debug.Log("Replaced " + logNames.Count + " colliders: <b>" + string.Join("</b>,<b> ", logNames.ToArray()) + "</b>");
        else Debug.Log("Added " + logNames.Count + " shadowcasters to: <b>" + string.Join("</b>,<b> ", logNames.ToArray()) + "</b>");
    }

    static void FilterSelection(Type t)
    {
        UnityEditor.Selection.objects =
            UnityEditor.Selection.GetTransforms(UnityEditor.SelectionMode.Deep /*| UnityEditor.SelectionMode.ExcludePrefab*/ | UnityEditor.SelectionMode.Editable)
            .Where(x => x.GetComponent(t))
            .Select(x => x.gameObject)
            .ToArray();
    }
    [UnityEditor.MenuItem("Tools/UASS/Filter hierarchy selection to Rigidbodies")]
    static void FilterSelectionRigidbodies() { FilterSelection(typeof(Rigidbody)); }
    [UnityEditor.MenuItem("Tools/UASS/Filter hierarchy selection to CharacterJoints")]
    static void FilterSelectionCharJoints() { FilterSelection(typeof(CharacterJoint)); }
    [UnityEditor.MenuItem("Tools/UASS/Filter hierarchy selection to UASSSpheres")]
    static void FilterSelectionSpheres() { FilterSelection(typeof(UASSSphere)); }
    [UnityEditor.MenuItem("Tools/UASS/Filter hierarchy selection to UASSCapsules")]
    static void FilterSelectionCapsules() { FilterSelection(typeof(UASSCapsule)); }
    [UnityEditor.MenuItem("Tools/UASS/Filter hierarchy selection to UASSBoxes")]
    static void FilterSelectionBoxes() { FilterSelection(typeof(UASSBox)); }
#endif
    #endregion
}