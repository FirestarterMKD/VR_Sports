using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class VideoManager : MonoBehaviour
{
   
   
	
	private VideoPlayer videoPlayer;
	public double time;

	private void Start() {
        videoPlayer = GetComponent<VideoPlayer>();
    }
	
	public void Play() {
		videoPlayer.Play();
	}
    public void Pause() {
		videoPlayer.Pause();
	}
	public void Stop() {
		videoPlayer.Stop();
	}
	
	private float speed = 2f;
    public void Rewind() {
		videoPlayer.time -= speed;
    } 
	
	public void URLToVideo(string url) {
		time = videoPlayer.time;
		
		videoPlayer.source = VideoSource.Url;
		videoPlayer.url = url;
		videoPlayer.Prepare();
		videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
	}
	
	
	private void VideoPlayer_prepareCompleted(VideoPlayer source) {
		Play();
		videoPlayer.time = time;
	}
}
