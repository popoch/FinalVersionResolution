using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuizScript : MonoBehaviour {

    public GameObject btn1, btn2, btn3, btn4, btn5, btn6;

    public GameObject feedback1, feedback2, feedback3;
    int i = 0;
    writeFile wf = new writeFile();

    void Start()
    {
        Button[] buttons = this.GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].onClick.AddListener(Onclicked);
        }
        if (ApplicationModel.curScene == 4)
        {
            wf.write("PART 1 SELECT QUIZ START");
        }
        else if (ApplicationModel.curScene == 5)
        {
            wf.write("PART 2 SELECT QUIZ START");
        }
        else if (ApplicationModel.curScene == 6)
        {
            wf.write("PART 3 SELECT QUIZ START");
        }
    }

    void Onclicked()
    {
        if (ApplicationModel.curScene == 4)
        {
            if (btn1.name.Equals(EventSystem.current.currentSelectedGameObject.name) || btn2.name.Equals(EventSystem.current.currentSelectedGameObject.name) || btn3.name.Equals(EventSystem.current.currentSelectedGameObject.name))
            {
                ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                wf.write("PART 1 SELECT QUIZ CLEAR");
                Application.LoadLevel(4);
            }
        }
        else if (ApplicationModel.curScene == 5)
        {
            if (btn1.name.Equals(EventSystem.current.currentSelectedGameObject.name))
            {
                ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                wf.write("PART 2 SELECT QUIZ CLEAR");
                Application.LoadLevel(5);
            }
            else
            {
                if (i == 0)
                {
                    feedback1.SetActive(true);
                }
                else if(i == 1)
                {
                    feedback2.SetActive(true);
                }
                else if(i == 2)
                {
                    feedback3.SetActive(true);
                }
                i++;
                if (i >= 3)
                {
                    i = 0;
                }
            }
        }
        else if(ApplicationModel.curScene == 6)
        {
            if (btn2.name.Equals(EventSystem.current.currentSelectedGameObject.name))
            {
                ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                wf.write("PART 3 SELECT QUIZ CLEAR");
                Application.LoadLevel(6);
            }
            else
            {
                feedback1.SetActive(true);
            }
        }
    }
}
