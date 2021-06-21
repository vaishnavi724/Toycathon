using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackFromQuiz : MonoBehaviour
{
    public void onBack() {
        AudioManager.Instance.StopSound("GameMusic");
        SceneManager.LoadScene(4);
    }

}

