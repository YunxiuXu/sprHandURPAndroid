using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {
	public float xScale, yScale, zScale, bias_x, bias_y, bias_z;
	public int isMouse = 1;
	// Use this for initialization
	void Start () {
		
	}
	int state = 0;
	// Update is called once per frame
	void FixedUpdate () {

		if(isMouse == 0)
			transform.localPosition = new Vector3(UDP.cam_x * xScale + bias_x, -UDP.cam_y * yScale + bias_y, (UDP.cam_z * zScale + bias_z));//izZon是开关 关了还要恢复到初始的-90

	}
}
