using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savedData : MonoBehaviour {

    public GameObject score;
    public GameObject overallAttempts;
    public GameObject type;
    public GameObject quiz1Attempts;
    public GameObject quiz2Attempts;
    public GameObject quiz3Attempts;
    public GameObject overallScore;
    public GameObject overallAttemptsinALL;
    public GameObject helperIntro;

    int result1 = 0;
    int result2 = 0;
    int result3 = 0;

    writeFile wf = new writeFile();

    void Start()
    {
        if (ApplicationModel.curScene == 2)
        {
            type.SetActive(false);
            helperIntro.SetActive(true);
            //score.GetComponent<Text>().text = ApplicationModel.timer0.ToString();
            wf.write("INTRO SUMMARY PAGE");
        }
        else if (ApplicationModel.curScene == 4)
        {
            type.SetActive(true);
            quiz1Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart1Quiz1.ToString();
            quiz2Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart1Quiz2.ToString();
            quiz3Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart1Quiz3.ToString();

            ApplicationModel.overallAttemptPart1Quiz = ApplicationModel.attemptPart1Quiz1 + ApplicationModel.attemptPart1Quiz2 + ApplicationModel.attemptPart1Quiz3;

            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallAttemptsinALL += ApplicationModel.overallAttemptPart1Quiz;
            }
            overallAttempts.GetComponent<Text>().text = ApplicationModel.overallAttemptPart1Quiz.ToString();
            overallAttemptsinALL.GetComponent<Text>().text = ApplicationModel.overallAttemptsinALL.ToString();
            
            result1 = ApplicationModel.attemptPart1Quiz1 * 100;
            if (result1 >= 500)
            {
                ApplicationModel.scorePart1Quiz1 = 0;
            }
            else
            {
                ApplicationModel.scorePart1Quiz1 = 500 - result1;
            }

            result2 = ApplicationModel.attemptPart1Quiz2 * 100;
            if (result2 >= 500)
            {
                ApplicationModel.scorePart1Quiz2 = 0;
            }
            else
            {
                ApplicationModel.scorePart1Quiz2 = 500 - result2;
            }

            result3 = ApplicationModel.attemptPart1Quiz3 * 100;
            if (result3 >= 500)
            {
                ApplicationModel.scorePart1Quiz3 = 0;
            }
            else
            {
                ApplicationModel.scorePart1Quiz3 = 500 - result3;
            }

            ApplicationModel.overallScorePart1Quiz = ApplicationModel.scorePart1Quiz1 + ApplicationModel.scorePart1Quiz2 + ApplicationModel.scorePart1Quiz3;
            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallScore += ApplicationModel.overallScorePart1Quiz;
            }
            score.GetComponent<Text>().text = ApplicationModel.overallScorePart1Quiz.ToString();
            overallScore.GetComponent<Text>().text = ApplicationModel.overallScore.ToString();

            //time.text = ApplicationModel.timer1.ToString();
            wf.write("PART 1 SUMMARY PAGE");

            ApplicationModel.addIn = false;
        }
        else if (ApplicationModel.curScene == 5)
        {
            type.SetActive(true);
            quiz1Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart2Quiz1.ToString();
            quiz2Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart2Quiz2.ToString();
            quiz3Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart2Quiz3.ToString();

            ApplicationModel.overallAttemptPart2Quiz = ApplicationModel.attemptPart2Quiz1 + ApplicationModel.attemptPart2Quiz2 + ApplicationModel.attemptPart2Quiz3;
            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallAttemptsinALL += ApplicationModel.overallAttemptPart2Quiz;
            }
            overallAttempts.GetComponent<Text>().text = ApplicationModel.overallAttemptPart2Quiz.ToString();
            overallAttemptsinALL.GetComponent<Text>().text = ApplicationModel.overallAttemptsinALL.ToString();

            result1 = ApplicationModel.attemptPart2Quiz1 * 100;
            if (result1 >= 500)
            {
                ApplicationModel.scorePart2Quiz1 = 0;
            }
            else
            {
                ApplicationModel.scorePart2Quiz1 = 500 - result1;
            }

            result2 = ApplicationModel.attemptPart2Quiz2 * 100;
            if (result2 >= 500)
            {
                ApplicationModel.scorePart2Quiz2 = 0;
            }
            else
            {
                ApplicationModel.scorePart2Quiz2 = 500 - result2;
            }

            result3 = ApplicationModel.attemptPart2Quiz3 * 100;
            if (result3 >= 500)
            {
                ApplicationModel.scorePart2Quiz3 = 0;
            }
            else
            {
                ApplicationModel.scorePart2Quiz3 = 500 - result3;
            }

            ApplicationModel.overallScorePart2Quiz = ApplicationModel.scorePart2Quiz1 + ApplicationModel.scorePart2Quiz2 + ApplicationModel.scorePart2Quiz3;
            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallScore += ApplicationModel.overallScorePart2Quiz;
            }
            score.GetComponent<Text>().text = ApplicationModel.overallScorePart2Quiz.ToString();
            overallScore.GetComponent<Text>().text = ApplicationModel.overallScore.ToString();

            //time.text = ApplicationModel.timer2.ToString();
            wf.write("PART 2 SUMMARY PAGE");

            ApplicationModel.addIn = false;
        }
        else if (ApplicationModel.curScene == 6)
        {
            type.SetActive(true);
            quiz1Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart3Quiz1.ToString();
            quiz2Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart3Quiz2.ToString();
            quiz3Attempts.GetComponent<Text>().text = ApplicationModel.attemptPart3Quiz3.ToString();

            ApplicationModel.overallAttemptPart3Quiz = ApplicationModel.attemptPart3Quiz1 + ApplicationModel.attemptPart3Quiz2 + ApplicationModel.attemptPart3Quiz3;
            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallAttemptsinALL += ApplicationModel.overallAttemptPart3Quiz;
            }
            overallAttempts.GetComponent<Text>().text = ApplicationModel.overallAttemptPart3Quiz.ToString();
            overallAttemptsinALL.GetComponent<Text>().text = ApplicationModel.overallAttemptsinALL.ToString();

            result1 = ApplicationModel.attemptPart3Quiz1 * 100;
            if (result1 >= 500)
            {
                ApplicationModel.scorePart3Quiz1 = 0;
            }
            else
            {
                ApplicationModel.scorePart3Quiz1 = 500 - result1;
            }

            result2 = ApplicationModel.attemptPart3Quiz2 * 100;
            if (result2 >= 500)
            {
                ApplicationModel.scorePart3Quiz2 = 0;
            }
            else
            {
                ApplicationModel.scorePart3Quiz2 = 500 - result2;
            }

            result3 = ApplicationModel.attemptPart3Quiz3 * 100;
            if (result3 >= 500)
            {
                ApplicationModel.scorePart3Quiz3 = 0;
            }
            else
            {
                ApplicationModel.scorePart3Quiz3 = 500 - result3;
            }

            ApplicationModel.overallScorePart3Quiz = ApplicationModel.scorePart3Quiz1 + ApplicationModel.scorePart3Quiz2 + ApplicationModel.scorePart3Quiz3;
            if (ApplicationModel.addIn == true)
            {
                ApplicationModel.overallScore += ApplicationModel.overallScorePart3Quiz;
            }
            score.GetComponent<Text>().text = ApplicationModel.overallScorePart3Quiz.ToString();
            overallScore.GetComponent<Text>().text = ApplicationModel.overallScore.ToString();

            //time.text = ApplicationModel.timer3.ToString();
            wf.write("PART 3 SUMMARY PAGE");

            ApplicationModel.addIn = false;
        }
        
    }

}
