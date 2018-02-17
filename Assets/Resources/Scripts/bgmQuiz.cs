using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bgmQuiz : MonoBehaviour {

    private AudioSource bgmSource;
    public AudioClip bgm;
    bool audiobegin = false;
    int curScene = 0;

    // Use this for initialization
    void Start()
    {
        bgmSource = gameObject.AddComponent<AudioSource>();
        bgmSource.loop = true;
        bgmSource.volume = 0.2f;
        curScene = SceneManager.GetActiveScene().buildIndex;
        audioPlay();
    }

    private void audioPlay()
    {
        if (curScene == 9 || curScene == 10 || curScene == 11 || curScene == 12 ||
            curScene == 13 || curScene == 14 || curScene == 15 || curScene == 16 ||
            curScene == 17 || curScene == 18 || curScene == 19 || curScene == 20 ||
            curScene == 21 || curScene == 22 || curScene == 23 || curScene == 24 ||
            curScene == 25)
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
