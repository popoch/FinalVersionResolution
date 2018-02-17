using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource audioSources;
    public AudioClip btnClip, btnErrorClip;

    // Use this for initialization
    void Start() {
        audioSources = gameObject.AddComponent<AudioSource>();
    }
    
    public void playSound()
    {
        audioSources.PlayOneShot(btnClip);
    }

    public void playSoundError()
    {
        audioSources.PlayOneShot(btnErrorClip);
    }
}
