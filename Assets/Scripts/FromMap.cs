using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FromMap : MonoBehaviour
{
    [SerializeField]
    public GameObject options;
    [SerializeField]
    public GameObject settingOptions;

    void Start()
    {
        options.gameObject.SetActive(true);
        settingOptions.gameObject.SetActive(false);
    }

    public void onTaj() {
        SceneManager.LoadScene(2);
    }
    
    public void onBack() {
        SceneManager.LoadScene(1);
    }

    public void onSettings(){
        options.gameObject.SetActive(false);
        settingOptions.gameObject.SetActive(true);
    }

    public void backSettings(){
        options.gameObject.SetActive(true);
        settingOptions.gameObject.SetActive(false);
    }

    public void onExit() {
        Application.Quit();
    }
}
