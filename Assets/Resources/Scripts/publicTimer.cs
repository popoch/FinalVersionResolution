using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class publicTimer : MonoBehaviour {

    public Text timeDisplay;
    public Text timePt0;
    public Text timePt1;
    public Text timePt2;
    public Text timePt3;
    public Text timePt4;

    void Update()
    {
        if(ApplicationModel.startorNot)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer += Time.deltaTime;
            timeDisplay.text = ApplicationModel.timer.ToString();
        }

        if (ApplicationModel.partIntro)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer0 += Time.deltaTime;
            timePt0.text = ApplicationModel.timer0.ToString();
        }

        if (ApplicationModel.partOne)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer1 += Time.deltaTime;
            timePt1.text = ApplicationModel.timer1.ToString();
        }

        if (ApplicationModel.partTwo)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer2 += Time.deltaTime;
            timePt2.text = ApplicationModel.timer2.ToString();
        }

        if (ApplicationModel.partThree)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer3 += Time.deltaTime;
            timePt3.text = ApplicationModel.timer3.ToString();
        }

        if (ApplicationModel.partFour)
        {
            //timer = Time.realtimeSinceStartup;
            ApplicationModel.timer4 += Time.deltaTime;
            timePt4.text = ApplicationModel.timer4.ToString();
        }
    }


    // Update is called once per frame
    public void state () {
        ApplicationModel.startorNot = true;        
	}

    public void pt0state()
    {
        ApplicationModel.partIntro = true;
    }

    public void pt1state()
    {
        ApplicationModel.partOne = true;
    }

    public void pt2state()
    {
        ApplicationModel.partTwo = true;
    }

    public void pt3state()
    {
        ApplicationModel.partThree = true;
    }

    public void pt4state()
    {
        ApplicationModel.partFour = true;
    }
}
