using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLandscape : MonoBehaviour
{
    //public static ScreenOrientation orientation;
    void Start()
    {
        /*Screen.autorotateToPortrait = true;

        Screen.autorotateToLandscapeLeft = true;

        Screen.orientation = ScreenOrientation.AutoRotation;*/
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
