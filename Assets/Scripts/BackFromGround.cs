using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackFromGround : MonoBehaviour
{
    public void onBackGround() {
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene(4);
    }
}
