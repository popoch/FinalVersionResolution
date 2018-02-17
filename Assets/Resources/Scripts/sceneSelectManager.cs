using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSelectManager : MonoBehaviour {

    public GameObject btnP1, btnP2, btnP3, btnP4;
    public GameObject btnP1side, btnP2side, btnP3side, btnP4side;
    writeFile wf = new writeFile();

    void Start()
    {
        ApplicationModel.curScene = SceneManager.GetActiveScene().buildIndex;

        btnP1.SetActive(ApplicationModel.part1Unlock);
        btnP1side.SetActive(!ApplicationModel.part1Unlock);

        btnP2.SetActive(ApplicationModel.part2Unlock);
        btnP2side.SetActive(!ApplicationModel.part2Unlock);

        btnP3.SetActive(ApplicationModel.part3Unlock);
        btnP3side.SetActive(!ApplicationModel.part3Unlock);

        btnP4.SetActive(ApplicationModel.part4Unlock);
        btnP4side.SetActive(!ApplicationModel.part4Unlock);
    }


    public void loadIntro() {
		loadLvl (2);
	}

	public void loadPt1() {
		loadLvl (4);
	}

	public void loadPt2() {
		loadLvl (5);
	}

	public void loadPt3() {
		loadLvl (6);
	}

	public void loadOutro() {
		loadLvl (7);
	}

	public void loadLvl(int lvl) {
        ApplicationModel.curLine = 0;
        ApplicationModel.endLine = 0;

        if (lvl == 2)
        {
            wf.write("INTRO");
        }
        else if (lvl == 4)
        {
            wf.write("PART 1");
        }
        else if(lvl == 5)
        {
            wf.write("PART 2");
        }
        else if (lvl == 6)
        {
            wf.write("PART 3");
        }
        else if (lvl == 7)
        {
            wf.write("OUTRO");
        }

        if (ApplicationModel.gameEnd == true)   //regame = reset
        {
            //ApplicationModel.timer = 0;  //overall
            //ApplicationModel.timer0 = 0; //intro
            //ApplicationModel.timer1 = 0; //part 1
            //ApplicationModel.timer2 = 0; //part 2
            //ApplicationModel.timer3 = 0; //part 3
            //ApplicationModel.timer4 = 0; //outro

            //ApplicationModel.attemptPart1Quiz1 = 0;
            //ApplicationModel.attemptPart1Quiz2 = 0;
            //ApplicationModel.attemptPart1Quiz3 = 0;
            //ApplicationModel.overallAttemptPart1Quiz = 0;
            //ApplicationModel.scorePart1Quiz1 = 0;
            //ApplicationModel.scorePart1Quiz2 = 0;
            //ApplicationModel.scorePart1Quiz3 = 0;
            //ApplicationModel.overallScorePart1Quiz = 0;

            //ApplicationModel.attemptPart2Quiz1 = 0;
            //ApplicationModel.attemptPart2Quiz2 = 0;
            //ApplicationModel.attemptPart2Quiz3 = 0;
            //ApplicationModel.overallAttemptPart2Quiz = 0;
            //ApplicationModel.scorePart2Quiz1 = 0;
            //ApplicationModel.scorePart2Quiz2 = 0;
            //ApplicationModel.scorePart2Quiz3 = 0;
            //ApplicationModel.overallScorePart2Quiz = 0;

            //ApplicationModel.attemptPart3Quiz1 = 0;
            //ApplicationModel.attemptPart3Quiz2 = 0;
            //ApplicationModel.attemptPart3Quiz3 = 0;
            //ApplicationModel.overallAttemptPart3Quiz = 0;
            //ApplicationModel.scorePart3Quiz1 = 0;
            //ApplicationModel.scorePart3Quiz2 = 0;
            //ApplicationModel.scorePart3Quiz3 = 0;
            //ApplicationModel.overallScorePart3Quiz = 0;

            //ApplicationModel.overallAttemptsinALL = 0;
            //ApplicationModel.overallScore = 0;

            //ApplicationModel.replayFromSummary = 0;
            //ApplicationModel.replayFromScene = 0;
            ApplicationModel.reset();
        }

        Application.LoadLevel (lvl);
	}
}
