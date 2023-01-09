using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//在手刚出现的时候让物体Static几秒钟
public class staticOnHandPresent : MonoBehaviour
{
    public GameObject RightHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(RightHand.activeSelf);
    }
}
