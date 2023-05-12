using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivation : MonoBehaviour
{
    public GameObject targetObject, targetObject2;
    public float delayTime = 3f;

    private void Start()
    {
        StartCoroutine(ActivateAfterDelay());
    }

    private System.Collections.IEnumerator ActivateAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        targetObject.SetActive(true);
        targetObject2.SetActive(true);
    }
}
