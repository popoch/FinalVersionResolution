using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitMenu : MonoBehaviour {

    public Canvas quit;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start () {
        quit = quit.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quit.enabled = false;
    }
	
	public void ExitPress()
    {
        ApplicationModel.startorNot = false;
        quit.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        ApplicationModel.startorNot = true;
        quit.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
