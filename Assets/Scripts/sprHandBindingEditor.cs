using UnityEditor;
using UnityEngine;
using System.Collections;
//控制脚本UI的 不用挂
[CustomEditor(typeof(sprHandBinding))]
public class sprHandBindingEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Get the current script
        sprHandBinding script = (sprHandBinding)target;

        // Draw the default inspector
        DrawDefaultInspector();

        // Draw a button in the inspector
        if (GUILayout.Button("Bind"))
        {
            script.Bind();
        }
        if (GUILayout.Button("FindTargetBoneByName"))
        {
            script.FindTargetBoneByName();
        }
        if (GUILayout.Button("ClearTargetBone"))
        {
            script.ClearTargetBone();
        }
    }
}
