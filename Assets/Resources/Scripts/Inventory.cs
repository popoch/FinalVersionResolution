using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged {
    [SerializeField] Transform slots;
    [SerializeField] Text inventoryText;

    public GameObject feedback;
    public GameObject feedback2;
    writeFile wf = new writeFile();

    private void Start()
    {
        feedBackSet();
        wf.write("DRAG AND DROP START");
        ApplicationModel.dropNumberCount = 0;
    }

    void Update()
    {
        HasChanged();
    }

    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        
        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().item;
            if (item)
            {
                builder.Append(item.name);
            }
        }
        inventoryText.text = builder.ToString();


        if (ApplicationModel.curScene == 4)
        {
            if (ApplicationModel.tempSaveCurLine == 49)
            {
                if (ApplicationModel.dropNumberCount == 4)
                {
                    if (inventoryText.text.Equals("print(\"Hello\")"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        wf.write("PART 1 QUIZ 1 CLEAR");
                        Application.LoadLevel(4);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(12);
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 54)
            {
                if (ApplicationModel.dropNumberCount == 3)
                {
                    if (inventoryText.text.Equals("Question = input( )"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        wf.write("PART 1 QUIZ 2 CLEAR");
                        Application.LoadLevel(4);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(13);
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 61)
            {
                if (ApplicationModel.dropNumberCount == 3)
                {
                    if (inventoryText.text.Equals("3 - 1"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        wf.write("PART 1 QUIZ 3 CLEAR");
                        Application.LoadLevel(4);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(14);
                    }
                }
            }
        }
        else if (ApplicationModel.curScene == 5)
        {
            if (ApplicationModel.tempSaveCurLine == 50)
            {
                if (ApplicationModel.dropNumberCount == 5)
                {
                    if (inventoryText.text.Equals("if x == 128 :"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        ApplicationModel.wrongCount = 0;
                        wf.write("PART 2 QUIZ 1 CLEAR");
                        Application.LoadLevel(5);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(15);
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 57)
            {
                if (ApplicationModel.part2quiz2_2 == true)
                {
                    if (ApplicationModel.dropNumberCount == 2)
                    {
                        if (inventoryText.text.Equals("else :"))
                        {
                            ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part2quiz2_2 = false;
                            wf.write("PART 2 QUIZ 2 CLEAR");
                            Application.LoadLevel(5);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(18);
                        }
                    }
                }
                else
                {
                    if (ApplicationModel.dropNumberCount == 5)
                    {
                        if (inventoryText.text.Equals("if x == 1 :"))
                        {
                            //ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part2quiz2_2 = true;
                            Application.LoadLevel(18);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(16);
                        }
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 63)
            {
                if (ApplicationModel.part2quiz3_3 == true)
                {
                    if (ApplicationModel.dropNumberCount == 2)
                    {
                        if (inventoryText.text.Equals("else :"))
                        {
                            ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part2quiz3_3 = false;
                            wf.write("PART 2 QUIZ 3 CLEAR");
                            Application.LoadLevel(5);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(20);
                        }
                    }
                }
                else if (ApplicationModel.part2quiz3_2 == true)
                {
                    if (ApplicationModel.dropNumberCount == 5)
                    {
                        if (inventoryText.text.Equals("elif x == 231 :"))
                        {
                            ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part2quiz3_2 = false;
                            ApplicationModel.part2quiz3_3 = true;
                            Application.LoadLevel(20);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(19);
                        }
                    }
                }
                else
                {
                    if (ApplicationModel.dropNumberCount == 5)
                    {
                        if (inventoryText.text.Equals("if x == 123 :"))
                        {
                            //ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part2quiz3_2 = true;
                            Application.LoadLevel(19);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(17);
                        }
                    }
                }
            }
        }
        else if(ApplicationModel.curScene == 6)
        {
            if (ApplicationModel.tempSaveCurLine == 46)
            {
                if (ApplicationModel.dropNumberCount == 5)
                {
                    if (inventoryText.text.Equals("for i in range(25) :"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        ApplicationModel.wrongCount = 0;
                        wf.write("PART 3 QUIZ 1 CLEAR");
                        Application.LoadLevel(6);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(22);
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 52)
            {
                if (ApplicationModel.part3quiz2_2 == true)
                {
                    if (ApplicationModel.dropNumberCount == 5)
                    {
                        if (inventoryText.text.Equals("if i == 1439 :"))
                        {
                            ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part3quiz2_2 = false;
                            wf.write("PART 3 QUIZ 2 CLEAR");
                            Application.LoadLevel(6);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(24);
                        }
                    }
                }
                else
                {
                    if (ApplicationModel.dropNumberCount == 5)
                    {
                        if (inventoryText.text.Equals("for i in range(1440) :"))
                        {
                            //ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                            ApplicationModel.dropNumberCount = 0;
                            ApplicationModel.wrongCount = 0;
                            ApplicationModel.part3quiz2_2 = true;
                            Application.LoadLevel(24);
                        }
                        else
                        {
                            ApplicationModel.feedback = true;
                            Application.LoadLevel(23);
                        }
                    }
                }
            }
            else if (ApplicationModel.tempSaveCurLine == 59)
            {
                if (ApplicationModel.dropNumberCount == 5)
                {
                    if (inventoryText.text.Equals("for i in range(25) :"))
                    {
                        ApplicationModel.curLine = ApplicationModel.tempSaveCurLine;
                        ApplicationModel.dropNumberCount = 0;
                        ApplicationModel.wrongCount = 0;
                        wf.write("PART 3 QUIZ 3 CLEAR");
                        Application.LoadLevel(6);
                    }
                    else
                    {
                        ApplicationModel.feedback = true;
                        Application.LoadLevel(25);
                    }
                }
            }
        }
    }

    private void feedBackSet()
    {
        if(ApplicationModel.feedback == true)
        {
            if (ApplicationModel.curScene == 4)
            {
                feedback.SetActive(ApplicationModel.feedback);
                if (ApplicationModel.tempSaveCurLine == 49)
                {
                    ApplicationModel.attemptPart1Quiz1 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 54)
                {
                    ApplicationModel.attemptPart1Quiz2 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 61)
                {
                    ApplicationModel.attemptPart1Quiz3 += 1;
                }
            }
            else if(ApplicationModel.curScene == 5)
            {
                if(ApplicationModel.wrongCount == 0)
                {
                    feedback.SetActive(ApplicationModel.feedback);
                }
                else if(ApplicationModel.wrongCount == 1)
                {
                    feedback2.SetActive(ApplicationModel.feedback);
                }
                ApplicationModel.wrongCount += 1;
                if (ApplicationModel.wrongCount >= 2)
                {
                    ApplicationModel.wrongCount = 0;
                }

                if (ApplicationModel.tempSaveCurLine == 50)
                {
                    ApplicationModel.attemptPart2Quiz1 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 57)
                {
                    ApplicationModel.attemptPart2Quiz2 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 63)
                {
                    ApplicationModel.attemptPart2Quiz3 += 1;
                }
            }
            else if (ApplicationModel.curScene == 6)
            {
                if (ApplicationModel.wrongCount == 0)
                {
                    feedback.SetActive(ApplicationModel.feedback);
                }
                else if (ApplicationModel.wrongCount == 1)
                {
                    feedback2.SetActive(ApplicationModel.feedback);
                }
                ApplicationModel.wrongCount += 1;
                if (ApplicationModel.wrongCount >= 2)
                {
                    ApplicationModel.wrongCount = 0;
                }

                if (ApplicationModel.tempSaveCurLine == 46)
                {
                    ApplicationModel.attemptPart3Quiz1 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 52)
                {
                    ApplicationModel.attemptPart3Quiz2 += 1;
                }
                else if (ApplicationModel.tempSaveCurLine == 59)
                {
                    ApplicationModel.attemptPart3Quiz3 += 1;
                }
            }
            ApplicationModel.feedback = false;
        }
    }

}
    namespace UnityEngine.EventSystems
    {
        public interface IHasChanged : IEventSystemHandler
        {
            void HasChanged();
        }
    }


