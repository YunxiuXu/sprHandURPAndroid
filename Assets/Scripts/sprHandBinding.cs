using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂这个
public class sprHandBinding : MonoBehaviour
{
    public GameObject sprBone;
    public string objectName;//自动生成的物体名字 如果子物体有这个名字就不重复生成了
    public List<GameObject> targetBone = new List<GameObject>();
    public void dosth(){
        objectName = sprBone.name + "(Clone)";
        print( objectName);
        for(int i = 0; i < targetBone.Count; i++){
            Transform childTransform = targetBone[i].transform.Find(objectName);
            if (childTransform == null)
            {
                GameObject instance = Instantiate(sprBone, targetBone[i].transform);
                instance.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
                instance.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
            }
        }
    }
}
