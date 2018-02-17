using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class touchGame : MonoBehaviour
{
    int move = 430;
    private TouchScreenKeyboard keyboard;
    public Text inputText, inputText2;
    public Text exText;
    public GameObject pt1_1Text, pt1_2Text, pt1_3Text, pt2Text, pt3Text;
 //   private string curText = "";
    public GameObject backgroundPt1, backgroundPt2, backgroundPt3;
    public GameObject arrowPt2, arrowPt3;
    public GameObject feedback1, feedback2;
    public GameObject exTextPanel;
    int i = 0;
    bool resultCheck = false;
    string tmpStringCheck = "";
    Vector3 textPanel;
    writeFile wf = new writeFile();

    void Start()
    {
        inputText.text = "";
        inputText2.text = "";
        keyboard = null;

        if (ApplicationModel.curScene == 4)
        {
            backgroundPt1.SetActive(true);
            arrowPt2.SetActive(false);
            arrowPt3.SetActive(true);

            if (ApplicationModel.tempSaveCurLine == 29)
            {
                pt1_1Text.SetActive(true);
                exText.text = @"print(""hello"")";
                wf.write("PART 1-1 TYPING QUIZ START");
            }
            else if(ApplicationModel.tempSaveCurLine == 40)
            {
                pt1_2Text.SetActive(true);
                exText.text = @"name = input()";
                wf.write("PART 1-2 TYPING QUIZ START");
            }
            else if (ApplicationModel.tempSaveCurLine == 45)
            {
                pt1_3Text.SetActive(true);
                exText.text = @"4+5";
                wf.write("PART 1-3 TYPING QUIZ START");
            }
        }
        else if(ApplicationModel.curScene == 5)
        {
            backgroundPt2.SetActive(true);
            arrowPt2.SetActive(true);
            arrowPt3.SetActive(false);
            pt2Text.SetActive(true);
            exText.text = @"if x > 10 :";
            wf.write("PART 2 TYPING QUIZ START");
        }
        else if (ApplicationModel.curScene == 6)
        {
            backgroundPt3.SetActive(true);
            arrowPt2.SetActive(false);
            arrowPt3.SetActive(true);
            pt3Text.SetActive(true);
            exText.text = @"for i in range(5) :";
            wf.write("PART 3 TYPING QUIZ START");
        }

        textPanel = new Vector3(exTextPanel.transform.position.x, exTextPanel.transform.position.y, exTextPanel.transform.position.z);
    }

    void Update()
    {
        if (ApplicationModel.curScene == 5)
        {
            if (keyboard != null && keyboard.done)
            {
                inputText2.text = keyboard.text;
                exTextPanel.transform.position = new Vector3(exTextPanel.transform.position.x, textPanel.y, exTextPanel.transform.position.z);
            }

            if (!inputText2.text.Equals(""))
            {
                if (!ApplicationModel.curText.Equals(inputText2.text))
                {
                    ApplicationModel.curText = inputText2.text;
                    
                    checkText();
                }
            }
            else
            {
                ApplicationModel.curText = "";
            }
        }
        else
        {
            if (keyboard != null && keyboard.done)
            {
                inputText.text = keyboard.text;
                exTextPanel.transform.position = new Vector3(exTextPanel.transform.position.x, textPanel.y, exTextPanel.transform.position.z);
            }

            if (!inputText.text.Equals(""))
            {
                if (!ApplicationModel.curText.Equals(inputText.text))
                {
                    ApplicationModel.curText = inputText.text;
                    
                    checkText();
                }
            }
            else
            {
                ApplicationModel.curText = "";
            }
        }
    }


    public void open()
    {
        resultCheck = true;
        keyboard = TouchScreenKeyboard.Open(ApplicationModel.curText, TouchScreenKeyboardType.ASCIICapable, false, false, false, false, exText.text);


        exTextPanel.transform.position = new Vector3(exTextPanel.transform.position.x, exTextPanel.transform.position.y + move, exTextPanel.transform.position.z);
    }

    void checkText()
    {
        string compareText;
        if (ApplicationModel.curScene == 5)
        {
            compareText = inputText2.text.ToLower();
        }
        else
        {
            compareText = inputText.text.ToLower();
        }
        if (compareText.Equals(exText.text))
        {
            ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
            
            if (ApplicationModel.curScene == 4)
            {
                wf.write("PART 1 TYPING QUIZ END");
                Application.LoadLevel(4);
            }
            else if (ApplicationModel.curScene == 5)
            {
                wf.write("PART 2 TYPING QUIZ END");
                Application.LoadLevel(5);
            }
            else if (ApplicationModel.curScene == 6)
            {
                wf.write("PART 3 TYPING QUIZ END");
                Application.LoadLevel(6);
            }
        }
        else if(!compareText.Equals(exText.text))
        {
            if (resultCheck == true)
            {
                if (i == 0)
                {
                    feedback1.SetActive(true);
                }
                else if (i == 1)
                {
                    feedback2.SetActive(true);
                }
                i++;
                if (i >= 2)
                {
                    i = 0;
                }
                resultCheck = false;
            }
        }
    }


    public int GetKeyboardSize()
    {
        using (AndroidJavaClass UnityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            AndroidJavaObject View = UnityClass.GetStatic<AndroidJavaObject>("currentActivity").Get<AndroidJavaObject>("mUnityPlayer").Call<AndroidJavaObject>("getView");

            using (AndroidJavaObject Rct = new AndroidJavaObject("android.graphics.Rect"))
            {
                View.Call("getWindowVisibleDisplayFrame", Rct);

                return Screen.height - Rct.Call<int>("height");
            }
        }
    }
}