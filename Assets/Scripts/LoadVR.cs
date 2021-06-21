using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class LoadVR : MonoBehaviour
{
    
    public void Start()
    {
        StartCoroutine(ActivatorVR("cardboard"));
    }

    public IEnumerator ActivatorVR(string str)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(str);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }

    
}
