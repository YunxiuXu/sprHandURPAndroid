using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂这个
public class sprHandBinding : MonoBehaviour
{
    public GameObject sprBone;
    public string objectName;//自动生成的物体名字 如果子物体有这个名字就不重复生成了
    public List<GameObject> targetBone = new List<GameObject>();
    public void Bind(){
        objectName = sprBone.name + "(Clone)";
        Transform childTransform = this.transform.Find(objectName);
        if (transform.childCount == 0){//如果没子物体
            for(int i = 0; i < targetBone.Count; i++){
                GameObject instance = Instantiate(sprBone, this.transform);
                instance.GetComponent<followBone>().aim = targetBone[i].gameObject;
                instance.name = targetBone[i].transform.name + "BoneGroup";
            // Transform childTransform = targetBone[i].transform.Find(objectName);
            // if (childTransform == null)
            // {
            //     GameObject instance = Instantiate(sprBone, targetBone[i].transform);
            //     instance.transform.localScale = targetBone[i].transform.lossyScale;
            //     //instance.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
            //     instance.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
            // }
            }    
        }
        
    }

    public string nameString = "";//写要追踪的关节的gameobject名字,用逗号分开
    public void FindTargetBoneByName(){
        string[] words = nameString.Split(',');
        GameObject[] objects = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject go in objects)
        {
            foreach(string str in words){
                if(go.transform.name.Contains(str)){
                    targetBone.Add(go);
                    break;
                } 
            }
            
            // 这里的 go 变量就是当前遍历到的物体
        }
    }

    public void ClearTargetBone(){
        targetBone.Clear();
    }
}
