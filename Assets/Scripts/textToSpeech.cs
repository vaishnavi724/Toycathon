using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
//using UniLang;
//using Proyecto26;
//susing Firebase.Sample.Auth;
	
// Supporting video https://www.youtube.com/watch?v=Md7siqXr7pM&t=24s

public class textToSpeech : MonoBehaviour
{
	AudioSource audio;
	[SerializeField]
    private string getText;
 	
 	void Start(){
 	
 		
 		audio = GetComponent<AudioSource>();
 		
 	}

	public void playAudio(){
		StartCoroutine(DownloadAudio(getText));
	} 
 
	IEnumerator DownloadAudio(string info) {
		//string language = "en-in";
		string language = "en-GB";
		//string language = "fr-CA";
   /*     if (language == "")
	    {
	        language = "en-in";
	    }
   */   
   
        string url = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + info + "&tl="+language;
        
        WWW www = new WWW(url);
        yield return www;

        audio.clip = www.GetAudioClip(false, true,AudioType.MPEG);
        audio.Play();
	}

}
 
	
