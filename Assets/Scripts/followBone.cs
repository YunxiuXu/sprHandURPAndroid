using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//让一块SprBone Follow对应的Bone, 应该是只Follow位置和旋转
[ExecuteInEditMode]
public class followBone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aim, childSprSolid;
    public Vector3 rotationOffset, positionOffset, scaleOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(aim != null){
            this.transform.position = aim.transform.position;
            var aimRotation = aim.transform.rotation;
            aimRotation = Quaternion.Euler(aimRotation.eulerAngles + rotationOffset);
            this.transform.rotation = aimRotation;
            if (Application.isPlaying)
            {
                // This code will only run when the game is in play mode
            }
            else
            {
                childSprSolid.transform.localPosition = positionOffset;
                childSprSolid.transform.localScale = scaleOffset;
            }
            
            
        }        
        
        
        
    }
}
