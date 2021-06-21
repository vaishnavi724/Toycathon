using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimatorTrain : MonoBehaviour
{
    
    public Sprite[] animatedImages;
    public Image animateImageObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*for(int i=0; i< animatedImages.Length; i++){
            animateImageObj.sprite = animatedImages[i];
        }
        SceneManager.LoadScene(3);*/
        animateImageObj.sprite = animatedImages[(int)(Time.time*25)%animatedImages.Length];
    }
}
