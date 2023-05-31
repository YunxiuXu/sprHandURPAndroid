using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//负责管理物体掉光了自动生成的

public class objectRespawn : MonoBehaviour
{
    public List<Color> colorlist;

    //public float deadY;
    float deadY = -1;
    Vector3 initPosition;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = this.transform.position;
        //initScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < deadY){
            GameObject go = Instantiate(this.gameObject, initPosition, new Quaternion(0, 0, 0, 1));
            //go.transform.localScale = initScale;
            //go.GetComponent<Renderer> ().material.color = colorlist[Random.Range(0, colorlist.Count)]; 
            Destroy(this.gameObject);
        }
        
    }
}