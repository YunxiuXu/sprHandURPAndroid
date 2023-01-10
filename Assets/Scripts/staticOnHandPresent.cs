using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//在手刚出现的时候让物体Static几秒钟 防止乱蹦
public class staticOnHandPresent : MonoBehaviour
{
    public GameObject oneHand;
    bool wasActive;
    // Start is called before the first frame update
    void Awake()
    {
        wasActive = oneHand.activeSelf;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oneHand.activeSelf && !wasActive)
        {
            for (int i = 0; i < this.gameObject.transform.childCount; i++)
            {
                Transform child = this.gameObject.transform.GetChild(i);
                //print(child.name);
                if(child.GetComponent<PHSolidBehaviour>() != null){
                    //print(child.name);
                    //print(child.GetComponent<PHSolidBehaviour>().GetDescStruct());
                    //child.GetComponent<PHSolidBehaviour>().ApplyDesc(child.GetComponent<PHSolidBehaviour>().GetDescStruct(), child.GetComponent<PHSolidBehaviour>().GetDescStruct());
                }
            }
            Debug.Log("objectActive");
        }

        wasActive = oneHand.activeSelf;
    }
}
