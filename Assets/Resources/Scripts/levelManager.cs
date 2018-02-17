using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

    public GameObject gameClearWindow;


	void Start () {
        ApplicationModel.curScene = SceneManager.GetActiveScene().buildIndex;
        gameClearWindow.SetActive(ApplicationModel.gameEnd);
	}

}
