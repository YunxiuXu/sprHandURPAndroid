using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDistance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftEye, RightEye;
    public float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LeftEye.transform.localPosition = new Vector3((-CapCalibration.IPD * distance / 2f), 0, 0);
        // RightEye.transform.localPosition = new Vector3((CapCalibration.IPD * distance / 2f), 0, 0);
    }
}
