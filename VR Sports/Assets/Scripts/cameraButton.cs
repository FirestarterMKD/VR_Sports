using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraButton : MonoBehaviour{
    
	public string url;
	public VideoManager videoManager;
	public void goToVideo() => videoManager.URLToVideo(url);
	
	
}
