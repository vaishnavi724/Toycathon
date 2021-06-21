using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class FromVR : MonoBehaviour
{
    public void Seen()
    {
        StartCoroutine(Activator3D("none"));
    }

    public IEnumerator Activator3D(string str)
    {
        SceneManager.LoadScene(4);
        UnityEngine.XR.XRSettings.LoadDeviceByName(str);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = false;
    }
}
