using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChestControl : MonoBehaviour
{

    [SerializeField]
    private Image _noteImage;
    [SerializeField]
    private Button Nextbutton;
    private GameObject NoteObject;
    [SerializeField]
    private Button button;
    [SerializeField]
    private Button AudioButton;
    [SerializeField]
    private Text completed;
    [SerializeField]
    private Button afterComplete;
    [SerializeField]
    private Image TouchImage;

    [SerializeField]
    private Button StopVideoButton;

    [SerializeField]
    private FixedJoystick LeftJoystick;
    [SerializeField]
    private FixedButton JumpButton;

    [SerializeField]
    private Button videoButton;
    public GameObject videoPlayer;

    [SerializeField]
    private Button constantBack;
    [SerializeField]
    private GameObject scoreCanvas;

    //public int timeToStop;

    AudioSource audio;

    int i = 0;

    void Start()
    {
        button.gameObject.SetActive(false);
        Nextbutton.gameObject.SetActive(false);
        AudioButton.gameObject.SetActive(false);
        afterComplete.gameObject.SetActive(false);
        completed.enabled = false;
        TouchImage.gameObject.SetActive(true);
        LeftJoystick.gameObject.SetActive(true);
        JumpButton.gameObject.SetActive(true);
        audio = GetComponent<AudioSource>();
        videoButton.gameObject.SetActive(false);
        videoPlayer.SetActive(false);
        StopVideoButton.gameObject.SetActive(false);
        constantBack.gameObject.SetActive(true);
        constantBack.interactable = true;
        scoreCanvas.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
 
        if (i == 0)
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(.75f, 0, 0);
            StartCoroutine(StopOpening());
            if (ScoreTextScript.coinAmount < 3)
            {
                ScoreTextScript.coinAmount += 1;

            }
            i += 1;
        }
       
    }

    IEnumerator StopOpening()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        _noteImage.enabled = true;
        button.gameObject.SetActive(true);
        button.interactable = true;
        AudioButton.gameObject.SetActive(true);
        AudioButton.interactable = true;
        TouchImage.gameObject.SetActive(false);
        LeftJoystick.gameObject.SetActive(false);
        JumpButton.gameObject.SetActive(false);
        videoButton.gameObject.SetActive(true);
        videoButton.interactable = true;
        /*if (ScoreTextScript.coinAmount == 3)
        {
            Nextbutton.gameObject.SetActive(true);
            Nextbutton.interactable = true;
        }*/
    }
    

    public void Call_destroy()
    {
        _noteImage.enabled = false;
        button.gameObject.SetActive(false);
        AudioButton.gameObject.SetActive(false);
        videoButton.gameObject.SetActive(false);
        videoPlayer.SetActive(false);
        GetComponent<Rigidbody>().detectCollisions = false;
        audio.Stop();
        if (ScoreTextScript.coinAmount == 3)
        {
            completed.enabled = true;
            afterComplete.gameObject.SetActive(true);
            afterComplete.interactable = true;
        }
        else {
            TouchImage.gameObject.SetActive(true);  
            LeftJoystick.gameObject.SetActive(true);
            JumpButton.gameObject.SetActive(true);
        }
        i = 0;
    }

    public void NextClicked()
    {
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene(4);
    }

    public void onPlayVideo()
    {
        //canvasobject.gameObject.SetActive(true);
        _noteImage.enabled = false;
        button.gameObject.SetActive(false);
        AudioButton.gameObject.SetActive(false);
        videoButton.gameObject.SetActive(false);
        StopVideoButton.gameObject.SetActive(true);
        StopVideoButton.interactable = true;
        constantBack.gameObject.SetActive(false);
        scoreCanvas.gameObject.SetActive(false);
        videoPlayer.SetActive(true);
        
    }

    public void onStopVideo(){
        videoPlayer.SetActive(false);
        _noteImage.enabled = true;
        button.gameObject.SetActive(true);
        AudioButton.gameObject.SetActive(true);
        videoButton.gameObject.SetActive(true);
        StopVideoButton.gameObject.SetActive(false);
        constantBack.gameObject.SetActive(true);
        constantBack.interactable = true;
        scoreCanvas.gameObject.SetActive(true);
        //canvasobject.gameObject.SetActive(false);
    }


}
