using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    

    void Start(){
        //canvasobject.gameObject.SetActive(false);
        
        videoPlayer.SetActive(false);
    }

    public void onPlayVideo()
    {
        //canvasobject.gameObject.SetActive(true);
        videoPlayer.SetActive(true);
    }

    void OnMouseDown(){
        videoPlayer.SetActive(false);
        //canvasobject.gameObject.SetActive(false);
    }
}
