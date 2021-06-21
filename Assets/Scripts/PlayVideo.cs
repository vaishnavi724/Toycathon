/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    public float timeToStop;

    void Start()
    {
        videoPlayer.SetActive(false);    
    }

    void OnMouseDown() {
        //if(player.gameObject.tag == "Player"){
            videoPlayer.SetActive(true);
            //Destroy(videoPlayer, timeToStop);
        //}
    }
}
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{

    [SerializeField]
    private Image _noteImage;
    [SerializeField]
    private Button Nextbutton;
    private GameObject NoteObject;
    [SerializeField]
    private Button button;
    int i = 0;
    public GameObject videoPlayer;

    void Start()
    {
        //button = GetComponent<Button>();
        //button.interactable = false;
        button.gameObject.SetActive(false);
        Nextbutton.gameObject.SetActive(false);
        videoPlayer.SetActive(false);
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
        //NoteObject.GetComponent<Canvas>().enabled = true;
        //myCanvas.enabled = true;
        if (ScoreTextScript.coinAmount == 3)
        {
            Nextbutton.gameObject.SetActive(true);
            Nextbutton.interactable = true;
        }
        videoPlayer.SetActive(true);
    }
    
    /*void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            //_noteImage.enabled = false;
            //NoteObject.GetComponent<Canvas>().enabled = false;
            myCanvas.enabled = false;
            GetComponent<Rigidbody>().detectCollisions = false;
            i = 0;
        }

       /* if (ScoreTextScript.coinAmount == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
        }*/
    //}

    /*public void DestroyObject()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(delegate { Call_destroy(); });

    }*/

    public void Call_destroy()
    {
        //myCanvas.enabled = false;
        _noteImage.enabled = false;
        //button.interactable = false;
        button.gameObject.SetActive(false);
        GetComponent<Rigidbody>().detectCollisions = false;
        i = 0;
    }

    public void NextClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}

