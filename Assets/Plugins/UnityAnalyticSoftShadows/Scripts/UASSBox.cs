using UnityEngine;

[ExecuteInEditMode]
#if UNITY_EDITOR 
[UnityEditor.CanEditMultipleObjects]
#endif
public class UASSBox : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size = Vector3.one;
    [Range(0f, 10f)]
    [Tooltip("Increase bias to decrease self-shadowing artifacts. (Tip: Boxes may not mix well with Indirect capsules on animated characters, so its recommended you approximate characters with Indirect capsules only)")]
    public float bias = 0.1f;
    public float Bias01 { get { return bias / 10f; } }
    [Range(0f, 10f)]
    [Tooltip("Distance before this box shadow starts fading out (Only for Indirect algorithm)")]
    public float fadeDistance = 1f;
    [Tooltip("Uses a cheaper way to render this box shadow, brings performance cost about on par with Spheres and Capsules, otherwise about 2x more expensive")]
    public bool cheap = false;

    void OnEnable()
    {
        UASS.Boxes.Add(this);
    }
    void OnDisable()
    {
        UASS.Boxes.Remove(this);
    }

    public void CopyParameters(BoxCollider col)
    {
        center = col.center;
        size = col.size;
    }
    [ContextMenu("Copy from BoxCollider", true)]
    bool ColliderAttached() { return GetComponent<BoxCollider>() != null; }
    [ContextMenu("Copy from BoxCollider")]
    void Reset()
    {
        var col = GetComponent<BoxCollider>();
        if (col) CopyParameters(col);
    }

#if UNITY_EDITOR
    [UnityEditor.MenuItem("CONTEXT/BoxCollider/Turn into UASSBox")]
    static void ToCaster(UnityEditor.MenuCommand command)
    {
        BoxCollider col = (BoxCollider)command.context;
        UnityEditor.Undo.AddComponent<UASSBox>(col.gameObject).CopyParameters(col);
        UnityEditor.Undo.DestroyObjectImmediate(col);
    }
    [UnityEditor.MenuItem("CONTEXT/UASSBox/Turn into BoxCollider")]
    static void ToCollider(UnityEditor.MenuCommand command)
    {
        UASSBox shadow = (UASSBox)command.context;
        var col = UnityEditor.Undo.AddComponent<BoxCollider>(shadow.gameObject);
        col.center = shadow.center;
        col.size = shadow.size;
        UnityEditor.Undo.DestroyObjectImmediate(shadow);
    }
#endif
    
}

//TODO: Give a "Rect Tool" style gizmo
#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(UASSBox)), UnityEditor.CanEditMultipleObjects]
public class UASSBoxEditor : UnityEditor.Editor
{
    UnityEditor.IMGUI.Controls.BoxBoundsHandle handle = new UnityEditor.IMGUI.Controls.BoxBoundsHandle();
    protected virtual void OnSceneGUI()
    {
        UASSBox caster = (UASSBox)target;
        if (!caster.isActiveAndEnabled) return;

        handle.center = caster.center;
        handle.size = caster.size;
        UnityEditor.EditorGUI.BeginChangeCheck();
        using (new UnityEditor.Handles.DrawingScope(Color.white * 0.9f/*new Color(.9f,.9f,.9f)*/, caster.transform.localToWorldMatrix))
            handle.DrawHandle();
        if (UnityEditor.EditorGUI.EndChangeCheck())
        {
            UnityEditor.Undo.RecordObject(caster, "Modify UASSBox");
            caster.center = handle.center;
            caster.size = handle.size;
        }
    }
}
#endif