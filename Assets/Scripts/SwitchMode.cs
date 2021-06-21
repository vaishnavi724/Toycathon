using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchMode : MonoBehaviour
{
    
    public void Play3D() {
        SceneManager.LoadScene(5);
    }

    public void PlayAR() {
        SceneManager.LoadScene(7);
    }

    public void PlayVR() {
        SceneManager.LoadScene(8);
    }

    public void PlayQuiz() {
        SceneManager.LoadScene(6);
    }

    public void onBack() {
        SceneManager.LoadScene(3);
    }

}
