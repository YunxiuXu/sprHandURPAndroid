using UnityEngine;

[ExecuteInEditMode]
#if UNITY_EDITOR 
[UnityEditor.CanEditMultipleObjects]
#endif
public class UASSSphere : MonoBehaviour
{
    public Vector3 center;
    public float radius = 0.5f;
    [Range(0f, 10f)]
    [Tooltip("Increase bias to decrease self-shadowing artifacts.")]
    public float bias = 0.1f;
    public float Bias01 { get { return bias / 10f; } }
    [Range(0f, 20f)]
    [Tooltip("Decrease max distance to improve blending when moving spheres are stacked near eachother, such as when on characters. (Only for Indirect algorithm)")]
    public float maxDistance = 10f;

    void OnEnable()
    {
        UASS.Spheres.Add(this);
    }

    void OnDisable()
    {
        UASS.Spheres.Remove(this);
    }

    public void CopyParameters(SphereCollider col)
    {
        center = col.center;
        radius = col.radius;
    }
    [ContextMenu("Copy from SphereCollider", true)]
    bool ColliderAttached() { return GetComponent<SphereCollider>() != null; }
    [ContextMenu("Copy from SphereCollider")]
    void Reset()
    {
        var col = GetComponent<SphereCollider>();
        if (col) CopyParameters(col);
    }

#if UNITY_EDITOR
    [UnityEditor.MenuItem("CONTEXT/SphereCollider/Turn into UASSSphere")]
    static void ToCaster(UnityEditor.MenuCommand command)
    {
        SphereCollider col = (SphereCollider)command.context;
        UnityEditor.Undo.AddComponent<UASSSphere>(col.gameObject).CopyParameters(col);
        UnityEditor.Undo.DestroyObjectImmediate(col);
    }
    [UnityEditor.MenuItem("CONTEXT/UASSSphere/Turn into SphereCollider")]
    static void ToCollider(UnityEditor.MenuCommand command)
    {
        UASSSphere shadow = (UASSSphere)command.context;
        var col = UnityEditor.Undo.AddComponent<SphereCollider>(shadow.gameObject);
        col.center = shadow.center;
        col.radius = shadow.radius;
        UnityEditor.Undo.DestroyObjectImmediate(shadow);
    }
#endif

}

//TODO: hide behind a namespace
#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(UASSSphere)), UnityEditor.CanEditMultipleObjects]
public class UASSSphereEditor : UnityEditor.Editor
{
    UnityEditor.IMGUI.Controls.SphereBoundsHandle handle = new UnityEditor.IMGUI.Controls.SphereBoundsHandle();
    protected virtual void OnSceneGUI()
    {
        UASSSphere caster = (UASSSphere)target;
        if (!caster.isActiveAndEnabled) return;
        using (new UnityEditor.Handles.DrawingScope(Color.white * 0.9f, Matrix4x4.TRS(caster.transform.position, caster.transform.rotation, Vector3.one)))
        {
            handle.center = TransformColliderCenterToHandleSpace(caster.transform, caster.center);
            handle.radius = caster.radius * MaxVector(AbsVector(caster.transform.lossyScale));
            UnityEditor.EditorGUI.BeginChangeCheck();
            handle.DrawHandle();
            if (UnityEditor.EditorGUI.EndChangeCheck())
            {
                UnityEditor.Undo.RecordObject(caster, "Modify UASSSphere");
                caster.center = TransformHandleCenterToColliderSpace(caster.transform, caster.center);
                float scaleFactor = MaxVector(AbsVector(caster.transform.lossyScale));
                caster.radius = Mathf.Approximately(scaleFactor, 0f) ? 0f : handle.radius / scaleFactor;
            }
        }
    }
    Vector3 AbsVector(Vector3 vec) { return new Vector3(Mathf.Abs(vec.x), Mathf.Abs(vec.y), Mathf.Abs(vec.z)); }
    float MaxVector(Vector3 vec) { return Mathf.Max(vec.x, vec.y, vec.z); }

    static Vector3 TransformColliderCenterToHandleSpace(Transform colliderTransform, Vector3 colliderCenter)
    {
        return UnityEditor.Handles.inverseMatrix * (colliderTransform.localToWorldMatrix * colliderCenter);
    }
    static Vector3 TransformHandleCenterToColliderSpace(Transform colliderTransform, Vector3 handleCenter)
    {
        return colliderTransform.localToWorldMatrix.inverse * (UnityEditor.Handles.matrix * handleCenter);
    }
}
#endif