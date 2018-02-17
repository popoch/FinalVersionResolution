using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bgmNormal : MonoBehaviour {

    private AudioSource bgmSource;
    public AudioClip bgm;
    bool audiobegin = false;
    int curScene = 0;

    // Use this for initialization
    void Start()
    {
        bgmSource = gameObject.AddComponent<AudioSource>();
        bgmSource.loop = true;
        bgmSource.volume = 0.15f;
        curScene = SceneManager.GetActiveScene().buildIndex;
        audioPlay();
    }

    private void audioPlay()
    {
        if (curScene == 2 || curScene == 4 || curScene == 5 || curScene == 6)
        {
            if (!audiobegin)
            {
                bgmSource.clip = bgm;
                bgmSource.Play();
                audiobegin = true;
            }
        }
    }
}
