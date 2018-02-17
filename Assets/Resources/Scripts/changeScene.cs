using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour {

    static public void load(int curScene, int curLineInfo)
    {
        if (curScene == 4) //Part One
        {
            if (curLineInfo == 8)
            {
                ApplicationModel.replayStart = 0;
            }
            else if (curLineInfo == 24)
            {
                ApplicationModel.replayStart = 9;
            }
            else if (curLineInfo == 45)
            {
                ApplicationModel.replayStart = 25;
            }
        }
        else if (curScene == 5) //Part Two
        {
            if (curLineInfo == 16)
            {
                ApplicationModel.replayStart = 0;
            }
            else if (curLineInfo == 23)
            {
                ApplicationModel.replayStart = 17;
            }
            else if (curLineInfo == 45)
            {
                ApplicationModel.replayStart = 24;
            }
        }
        else if (curScene == 6) //Part Three
        {
            if (curLineInfo == 7)
            {
                ApplicationModel.replayStart = 0;
            }
            else if (curLineInfo == 18)
            {
                ApplicationModel.replayStart = 8;
            }
            else if (curLineInfo == 39)
            {
                ApplicationModel.replayStart = 19;
            }
        }
        else
        {
            Debug.Log("Wrong Input");
        }

    }
}


                