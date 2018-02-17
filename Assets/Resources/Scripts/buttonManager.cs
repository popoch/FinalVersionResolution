using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {

	private int textLine;
    private int endAt;
    public GameObject btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;
    public GameObject bgPt0, bgPt1, bgPt2, bgPt3;

    writeFile wf = new writeFile();

    void Start()
    {
        ApplicationModel.summaryPage = true;

        if (ApplicationModel.curScene == 2)
        {
            btn1.SetActive(true);
            btn1.GetComponentInChildren<Text>().text = "프로그램이란?";

            btn2.SetActive(true);
            btn2.GetComponentInChildren<Text>().text = "Python 이란?";

            btn3.SetActive(true);
            btn3.GetComponentInChildren<Text>().text = "입력";

            btn4.SetActive(true);
            btn4.GetComponentInChildren<Text>().text = "출력";

            btn5.SetActive(true);
            btn5.GetComponentInChildren<Text>().text = "수학";

            btn6.SetActive(true);
            btn6.GetComponentInChildren<Text>().text = "조건부 실행";

            btn7.SetActive(true);
            btn7.GetComponentInChildren<Text>().text = "반복";

            btn8.SetActive(true);
            //btn8.GetComponentInChildren<Text>().text = "Part1";

            bgPt0.SetActive(true);
            bgPt1.SetActive(false);
            bgPt2.SetActive(false);
            bgPt3.SetActive(false);
        }
        else if(ApplicationModel.curScene == 4)
        {
            btn1.SetActive(true);
            btn1.GetComponentInChildren<Text>().text = "프로그래밍에서 문법이란?";

            btn2.SetActive(true);
            btn2.GetComponentInChildren<Text>().text = "print(\"...\")";

            btn3.SetActive(true);
            btn3.GetComponentInChildren<Text>().text = "Variable";

            btn4.SetActive(true);
            btn4.GetComponentInChildren<Text>().text = "input()";

            btn5.SetActive(true);
            btn5.GetComponentInChildren<Text>().text = "math 1 + 2";

            btn6.SetActive(false);
            btn7.SetActive(false);

            btn8.SetActive(true);
            //btn8.GetComponentInChildren<Text>().text = "Part2";

            bgPt0.SetActive(false);
            bgPt1.SetActive(true);
            bgPt2.SetActive(false);
            bgPt3.SetActive(false);
        }
        else if (ApplicationModel.curScene == 5)
        {
            btn1.SetActive(true);
            btn1.GetComponentInChildren<Text>().text = "if문과 조건문이란?";

            btn2.SetActive(true);
            btn2.GetComponentInChildren<Text>().text = "==, != 부등호란?";

            btn3.SetActive(true);
            btn3.GetComponentInChildren<Text>().text = "if condition";

            btn4.SetActive(true);
            btn4.GetComponentInChildren<Text>().text = "if condition: else...";

            btn5.SetActive(true);
            btn5.GetComponentInChildren<Text>().text = "~ elif condition: else";

            btn6.SetActive(false);
            btn7.SetActive(false);

            btn8.SetActive(true);
            //btn8.GetComponentInChildren<Text>().text = "Part3";

            bgPt0.SetActive(false);
            bgPt1.SetActive(false);
            bgPt2.SetActive(true);
            bgPt3.SetActive(false);
        }
        else if (ApplicationModel.curScene == 6)
        {
            btn1.SetActive(true);
            btn1.GetComponentInChildren<Text>().text = "반복과 for문 이란?";

            btn2.SetActive(true);
            btn2.GetComponentInChildren<Text>().text = "값 증가 규칙";

            btn3.SetActive(true);
            btn3.GetComponentInChildren<Text>().text = "for ~ in range(number):";

            btn4.SetActive(true);
            btn4.GetComponentInChildren<Text>().text = "for ~: if condition";

            btn5.SetActive(false);
            btn6.SetActive(false);
            btn7.SetActive(false);
            bgPt3.SetActive(true);

            btn8.SetActive(true);
            //btn8.GetComponentInChildren<Text>().text = "Outro";
        }
        
    }

    public void loadFirst()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 36;  //part 1: 프로그램이란?
            endAt = 39;
        }
        else if (ApplicationModel.curScene == 4)
        {
            textLine = 9;   //part 2: 문법이란?
            endAt = 24;
        }
        else if (ApplicationModel.curScene == 5)
        {
            textLine = 15;  //part 3: if문과 조건문
            endAt = 24;
        }
        else if (ApplicationModel.curScene == 6)
        {
            textLine = 9;  //part 4: 반복과 for문?
            endAt = 21;
        }
        ApplicationModel.summaryPage = true;
        ApplicationModel.replayFromSummary += 1;
        loadLvl(ApplicationModel.curScene);
    }
    public void loadSecond()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 40;  //part 1: python이란?
            endAt = 43;
        }
        else if (ApplicationModel.curScene == 4)
        {
            textLine = 25;  //part 2: print?
            endAt = 26;
        }
        else if (ApplicationModel.curScene == 5)
        {
            textLine = 25;  //part 3: 부등호란
            endAt = 28;
        }
        else if (ApplicationModel.curScene == 6)
        {
            textLine = 22;  //part 4: increment
            endAt = 24;
        }
        ApplicationModel.summaryPage = true;
        ApplicationModel.replayFromSummary += 1;
        loadLvl(ApplicationModel.curScene);
    }
    public void loadThird()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 49;  //part 1: input
            endAt = 50;
        }
        else if (ApplicationModel.curScene == 4)
        {
            textLine = 32;  //part 2: variable?
            endAt = 34;
        }
        else if (ApplicationModel.curScene == 5)
        {
            textLine = 29;  //part 3: if condition
            endAt = 30;
        }
        else if (ApplicationModel.curScene == 6)
        {
            textLine = 25;  //part 4: for variable in range(number):
            endAt = 27;
        }
        ApplicationModel.summaryPage = true;
        ApplicationModel.replayFromSummary += 1;
        loadLvl(ApplicationModel.curScene);
    }
    public void loadFourth()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 51;  //part 1: output
            endAt = 52;
        }
        else if (ApplicationModel.curScene == 4)
        {
            textLine = 35;  //part 2: input?
            endAt = 36;
        }
        else if (ApplicationModel.curScene == 5)
        {
            textLine = 33;  //part 3: if condition: else...
            endAt = 37;
        }
        else if (ApplicationModel.curScene == 6)
        {
            textLine = 33;  //part 4: for variable in range(number): if condition
            endAt = 38;
        }
        ApplicationModel.summaryPage = true;
        ApplicationModel.replayFromSummary += 1;
        loadLvl(ApplicationModel.curScene);
    }
    public void loadFifth()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 53;  //part 1: math
            endAt = 54;
        }
        else if (ApplicationModel.curScene == 4)
        {
            textLine = 40;  //part 2: math 1+2
            endAt = 42;
        }
        else if (ApplicationModel.curScene == 5)
        {
            textLine = 38;  //part 3: if condition: elif condition else...
            endAt = 44;
        }
        ApplicationModel.summaryPage = true;
        ApplicationModel.replayFromSummary += 1;
        loadLvl(ApplicationModel.curScene);
    }
    public void loadSixth()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 55;  //part 1: conditional execution
            endAt = 57;
            ApplicationModel.summaryPage = true;
            ApplicationModel.replayFromSummary += 1;
            loadLvl(ApplicationModel.curScene);
        }
    }
    public void loadSeventh()
    {
        if (ApplicationModel.curScene == 2)
        {
            textLine = 58;  //part 1: repetition
            endAt = 60;
            ApplicationModel.summaryPage = true;
            ApplicationModel.replayFromSummary += 1;
            loadLvl(ApplicationModel.curScene);
        }
    }
    public void loadNextLevel()
    {
        textLine = 0;
        endAt = 0;

        ApplicationModel.partIntro = false;
        ApplicationModel.partOne = false;
        ApplicationModel.partTwo = false;
        ApplicationModel.partThree = false;
        ApplicationModel.partFour = false;
        ApplicationModel.summaryPage = false;
        ApplicationModel.addIn = true;

        if (ApplicationModel.curScene == 2) //intro -> part 1
        {
            ApplicationModel.partOne = true;
            wf.write("FROM INTRO TO PART 1");
            loadLvl(4);
        }
        else if (ApplicationModel.curScene == 4)    //part 1 -> part 2
        {
            ApplicationModel.partTwo = true;
            wf.write("FROM PART 1 TO PART 2");
            loadLvl(5);
        }
        else if (ApplicationModel.curScene == 5)    //part 2 -> part 3
        {
            ApplicationModel.partThree = true;
            wf.write("FROM PART 2 TO PART 3");
            loadLvl(6);
        }
        else if (ApplicationModel.curScene == 6)    //part 3 -> outro
        {
            ApplicationModel.partFour = true;
            wf.write("FROM PART 3 TO OUTRO");
            loadLvl(7);
        }
    }

    public void loadLvl(int lvl) {
		ApplicationModel.curLine = textLine;
		ApplicationModel.endLine = endAt;
        
        Application.LoadLevel (lvl);
	}
}
