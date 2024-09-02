﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {
    public AudioSource sorse { get; set;}
    public static SoundPlayer regit {get; set;}
    private float tim;
	void Awake(){
		sorse = GetComponent<AudioSource> ();
		if (regit == null) {
			regit = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		regit = null;
	}
    public void Play(AudioClip clip, float volume)
    {
        sorse.PlayOneShot(clip, volume);
    }
}