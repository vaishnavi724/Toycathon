﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waiting());
        

    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
