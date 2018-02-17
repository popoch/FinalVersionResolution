using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	//public float playedTime = 0.0f;
	public Text timeDisplay;
    public Text title;
    public GameObject panel;

    private float currentTime;
    private float difTime = 0.0f;

    public static bool gamePaused = false;
	
	// Update is called once per frame
	void Update () {
        if (!gamePaused)
        {
            //playedTime += Time.deltaTime;
            currentTime = Time.realtimeSinceStartup;
            currentTime = currentTime - difTime;
            timeDisplay.text = currentTime.ToString();

        } else {
            difTime = Time.realtimeSinceStartup - currentTime;
            
        }
        //timeDisplay.text = Mathf.RoundToInt (playedTime).ToString () + " seconds"; 
        
    }

    public void setPauseResume()
    {
        if (!gamePaused)
        {
            gamePaused = true;
            title.text = "Resume";
            panel.SetActive(gamePaused);
            
        } else if(gamePaused)
        {
            gamePaused = false;
            title.text = "Pause";
            panel.SetActive(gamePaused);
          
        }
    }

}
