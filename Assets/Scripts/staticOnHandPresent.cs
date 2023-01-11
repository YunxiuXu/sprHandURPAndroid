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
            StartCoroutine(DisableHandForNSecs(0.2f));
        }

        wasActive = oneHand.activeSelf;
    }

    IEnumerator DisableHandForNSecs(float time)//这样遍历效率可能低 日后改 下次一定
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            Transform child = this.gameObject.transform.GetChild(i);
            //print(child.name);
            if(child.GetComponent<PHSolidBehaviour>() != null){ 
                child.GetComponent<PHSolidBehaviour>().isStop = true;
            }
        }    //freeze all Objects

        yield return new WaitForSeconds(time);

        //recover after several seconds
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            Transform child = this.gameObject.transform.GetChild(i);
            //print(child.name);
            if(child.GetComponent<PHSolidBehaviour>() != null){ 
                child.GetComponent<PHSolidBehaviour>().isStop = false;
            }
        }   
    }

}
