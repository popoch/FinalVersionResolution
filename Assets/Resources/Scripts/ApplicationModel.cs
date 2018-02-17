using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationModel : MonoBehaviour {

    static public int curLine = 0;
	static public int endLine = 0;
    static public int curScene = 0;
    static public bool startorNot = false;
    static public float timer = 0;  //overall
    static public float timer0 = 0; //intro
    static public float timer1 = 0; //part 1
    static public float timer2 = 0; //part 2
    static public float timer3 = 0; //part 3
    static public float timer4 = 0; //outro

    static public int tempSaveCurLine = 0;
    
    static public int right = 0;
    static public int left = 0;

    static public int endAtLine = 0;
    static public bool replay = false;

    static public bool partIntro = false;
    static public bool partOne = false;
    static public bool partTwo = false;
    static public bool partThree = false;
    static public bool partFour = false;

    static public int replayStart = 0;

    static public bool feedback = false;

    static public int attemptPart1Quiz1 = 0;
    static public int attemptPart1Quiz2 = 0;
    static public int attemptPart1Quiz3 = 0;
    static public int overallAttemptPart1Quiz = 0;
    static public int scorePart1Quiz1 = 0;
    static public int scorePart1Quiz2 = 0;
    static public int scorePart1Quiz3 = 0;
    static public int overallScorePart1Quiz = 0;

    static public int attemptPart2Quiz1 = 0;
    static public int attemptPart2Quiz2 = 0;
    static public int attemptPart2Quiz3 = 0;
    static public int overallAttemptPart2Quiz = 0;
    static public int scorePart2Quiz1 = 0;
    static public int scorePart2Quiz2 = 0;
    static public int scorePart2Quiz3 = 0;
    static public int overallScorePart2Quiz = 0;

    static public int attemptPart3Quiz1 = 0;
    static public int attemptPart3Quiz2 = 0;
    static public int attemptPart3Quiz3 = 0;
    static public int overallAttemptPart3Quiz = 0;
    static public int scorePart3Quiz1 = 0;
    static public int scorePart3Quiz2 = 0;
    static public int scorePart3Quiz3 = 0;
    static public int overallScorePart3Quiz = 0;

    static public int overallAttemptsinALL = 0;
    static public int overallScore = 0;

    static public int dropNumberCount = 0;
    static public int wrongCount = 0;

    static public bool part2quiz2_2 = false;
    static public bool part2quiz3_2 = false;
    static public bool part2quiz3_3 = false;

    static public bool part3quiz2_2 = false;

    static public bool gameEnd = false;
    
    static public bool part1Unlock = false;
    static public bool part2Unlock = false;
    static public bool part3Unlock = false;
    static public bool part4Unlock = false;

    static public string curText = "";

    static public bool summaryPage = false;

    static public int dirNumb = 1;
    static public int fileNumb = 1;

    static public bool addIn = true;

    static public int replayFromSummary = 0;
    static public int replayFromScene = 0;

    static public void reset ()
    {
        ApplicationModel.timer = 0;  //overall
        ApplicationModel.timer0 = 0; //intro
        ApplicationModel.timer1 = 0; //part 1
        ApplicationModel.timer2 = 0; //part 2
        ApplicationModel.timer3 = 0; //part 3
        ApplicationModel.timer4 = 0; //outro

        ApplicationModel.attemptPart1Quiz1 = 0;
        ApplicationModel.attemptPart1Quiz2 = 0;
        ApplicationModel.attemptPart1Quiz3 = 0;
        ApplicationModel.overallAttemptPart1Quiz = 0;
        ApplicationModel.scorePart1Quiz1 = 0;
        ApplicationModel.scorePart1Quiz2 = 0;
        ApplicationModel.scorePart1Quiz3 = 0;
        ApplicationModel.overallScorePart1Quiz = 0;

        ApplicationModel.attemptPart2Quiz1 = 0;
        ApplicationModel.attemptPart2Quiz2 = 0;
        ApplicationModel.attemptPart2Quiz3 = 0;
        ApplicationModel.overallAttemptPart2Quiz = 0;
        ApplicationModel.scorePart2Quiz1 = 0;
        ApplicationModel.scorePart2Quiz2 = 0;
        ApplicationModel.scorePart2Quiz3 = 0;
        ApplicationModel.overallScorePart2Quiz = 0;

        ApplicationModel.attemptPart3Quiz1 = 0;
        ApplicationModel.attemptPart3Quiz2 = 0;
        ApplicationModel.attemptPart3Quiz3 = 0;
        ApplicationModel.overallAttemptPart3Quiz = 0;
        ApplicationModel.scorePart3Quiz1 = 0;
        ApplicationModel.scorePart3Quiz2 = 0;
        ApplicationModel.scorePart3Quiz3 = 0;
        ApplicationModel.overallScorePart3Quiz = 0;

        ApplicationModel.overallAttemptsinALL = 0;
        ApplicationModel.overallScore = 0;

        ApplicationModel.replayFromSummary = 0;
        ApplicationModel.replayFromScene = 0;
    }
}
