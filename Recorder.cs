using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour {

	public static string DeviceName;

	// Use this for initialization
	void Start () {
		foreach (string device in Microphone.devices) {
			DeviceName = device;
			Debug.Log("Name: " + DeviceName);
		}

		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start(DeviceName, true, 100, 44100);
		aud.Play();

		if (Microphone.IsRecording (DeviceName)) {
			Debug.Log ("Recording...");
		}

		//aud.clip = Microphone.End ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
