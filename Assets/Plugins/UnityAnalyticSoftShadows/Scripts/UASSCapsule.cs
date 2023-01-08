using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
#if UNITY_EDITOR 
[UnityEditor.CanEditMultipleObjects]
#endif
public class UASSCapsule : MonoBehaviour
{
    public Vector3 center;
    public float radius = 0.5f;
    public float height = 1f;
    public enum Direction { XAxis = 0, YAxis = 1, ZAxis = 2 }
    public Direction direction = Direction.YAxis;
    [Range(0f, 10f)]
    [Tooltip("Increase bias to decrease self-shadowing artifacts.")]
    public float bias = 0.1f;
    public float Bias01 { get { return bias / 10f; } }
    [Range(0f, 20f)]
    [Tooltip("Decrease max distance to improve blending when moving capsules are stacked near eachother, such as when on characters. (Only for Indirect algorithm)")]
    public float maxDistance = 10f;
    //TODO: double split option

    void OnEnable()
    {
        UASS.Capsules.Add(this);
    }
    void OnDisable()
    {
        UASS.Capsules.Remove(this);
    }
    void OnValidate()
    {
        radius = Mathf.Max(0f, radius);
        height = Mathf.Max(0f, height);
    }

    public void CopyParameters(CapsuleCollider col)
    {
        center = col.center;
        radius = col.radius;
        height = col.height;
        direction = (Direction)col.direction;
    }
    [ContextMenu("Copy from CapsuleCollider", true)]
    bool ColliderAttached() { return GetComponent<CapsuleCollider>() != null; }
    [ContextMenu("Copy from CapsuleCollider")]
    void Reset()
    {
        var col = GetComponent<CapsuleCollider>();
        if (col) CopyParameters(col);
    }

#if UNITY_EDITOR
    [UnityEditor.MenuItem("CONTEXT/CapsuleCollider/Turn into UASSCapsule")]
    static void ToCaster(UnityEditor.MenuCommand command)
    {
        CapsuleCollider col = (CapsuleCollider)command.context;
        UnityEditor.Undo.AddComponent<UASSCapsule>(col.gameObject).CopyParameters(col);
        UnityEditor.Undo.DestroyObjectImmediate(col);
    }
    [UnityEditor.MenuItem("CONTEXT/UASSCapsule/Turn into CapsuleCollider")]
    static void ToCollider(UnityEditor.MenuCommand command)
    {
        UASSCapsule shadow = (UASSCapsule)command.context;
        var col = UnityEditor.Undo.AddComponent<CapsuleCollider>(shadow.gameObject);
        col.center = shadow.center;
        col.radius = shadow.radius;
        col.height = shadow.height;
        col.direction = (int)shadow.direction;
        UnityEditor.Undo.DestroyObjectImmediate(shadow);
    }
#endif

}
#if UNITY_EDITOR
//https://github.com/Unity-Technologies/UnityCsReference/blob/0c33b107d009762c354d942241ce72b426729523/Editor/Mono/Inspector/CapsuleColliderEditor.cs
[UnityEditor.CustomEditor(typeof(UASSCapsule)), UnityEditor.CanEditMultipleObjects]
public class ShadowsCapsuleEditor : UnityEditor.Editor
{
    UnityEditor.IMGUI.Controls.CapsuleBoundsHandle handle = new UnityEditor.IMGUI.Controls.CapsuleBoundsHandle();

    protected virtual void OnSceneGUI()
    {
        UASSCapsule caster = (UASSCapsule)target;
        if (!caster.isActiveAndEnabled) return;

        // prevent possibility that user increases height if radius scale is zero and user drags (non-moving) radius handles to exceed height extents
        float radiusScaleFactor;
        GetCapsuleColliderHandleScale(caster.transform.lossyScale, (int)caster.direction, out radiusScaleFactor);
        handle.axes = UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes.All;
        if (radiusScaleFactor == 0f)
            handle.axes = (UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes)caster.direction;
        
        using (new UnityEditor.Handles.DrawingScope(Color.white * 0.9f, Matrix4x4.TRS(caster.transform.position, caster.transform.rotation, Vector3.one)))
        {
            SetHandle(caster);
            UnityEditor.EditorGUI.BeginChangeCheck();
            handle.DrawHandle();
            if (UnityEditor.EditorGUI.EndChangeCheck())
            {
                UnityEditor.Undo.RecordObject(caster, "Modify UASSCapsule");
                SetCollider(caster);
            }
        }
    }

    void SetHandle(UASSCapsule collider)
    {
        handle.center = TransformColliderCenterToHandleSpace(collider.transform, collider.center);
        float radiusScaleFactor;
        Vector3 sizeScale =
            GetCapsuleColliderHandleScale(collider.transform.lossyScale, (int)collider.direction, out radiusScaleFactor);
        handle.height = handle.radius = 0f;
        handle.height = collider.height * Mathf.Abs(sizeScale[(int)collider.direction]);
        handle.radius = collider.radius * radiusScaleFactor;
        handle.heightAxis = (UnityEditor.IMGUI.Controls.CapsuleBoundsHandle.HeightAxis)collider.direction;
    }
    void SetCollider(UASSCapsule collider)
    {
        collider.center = TransformHandleCenterToColliderSpace(collider.transform, handle.center);
        float radiusScaleFactor;
        Vector3 sizeScale =
            GetCapsuleColliderHandleScale(collider.transform.lossyScale, (int)collider.direction, out radiusScaleFactor);
        sizeScale = InvertScaleVector(sizeScale);
        // only apply changes to collider radius/height if scale factor from transform is non-zero
        if (radiusScaleFactor != 0f)
            collider.radius = handle.radius / radiusScaleFactor;
        if (sizeScale[(int)collider.direction] != 0f)
            collider.height = handle.height * Mathf.Abs(sizeScale[(int)collider.direction]);
    }
    Vector3 GetCapsuleColliderHandleScale(Vector3 lossyScale, int capsuleDirection, out float radiusScaleFactor)
    {
        radiusScaleFactor = 0f;
        for (int axis = 0; axis < 3; ++axis)
        {
            if (axis != capsuleDirection)
                radiusScaleFactor = Mathf.Max(radiusScaleFactor, Mathf.Abs(lossyScale[axis]));
        }
        for (int axis = 0; axis < 3; ++axis)
        {
            if (axis != capsuleDirection)
                lossyScale[axis] = Mathf.Sign(lossyScale[axis]) * radiusScaleFactor;
        }
        return lossyScale;
    }
    static Vector3 TransformColliderCenterToHandleSpace(Transform colliderTransform, Vector3 colliderCenter)
    {
        return UnityEditor.Handles.inverseMatrix * (colliderTransform.localToWorldMatrix * colliderCenter);
    }
    static Vector3 TransformHandleCenterToColliderSpace(Transform colliderTransform, Vector3 handleCenter)
    {
        return colliderTransform.localToWorldMatrix.inverse * (UnityEditor.Handles.matrix * handleCenter);
    }
    Vector3 InvertScaleVector(Vector3 scaleVector)
    {
        for (int axis = 0; axis < 3; ++axis)
            scaleVector[axis] = scaleVector[axis] == 0f ? 0f : 1f / scaleVector[axis];
        return scaleVector;
    }
}
#endif