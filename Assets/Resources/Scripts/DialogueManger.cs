using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManger : MonoBehaviour
{
    public GameObject textBox;
     
    public Text theText;
    public GameObject replayBtn;
    public GameObject nextArrow;
    public GameObject prevArrow;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    //public int endAtLine;

    public Rect Left = new Rect(0, 0, 0, 0);
    public Rect Right = new Rect(0, 0, 0, 0);

    public GameObject sideMenu;
    writeFile wf = new writeFile();

    private AudioSource audioSources;
    private AudioClip[] btnClips;

    private bool audioRun = false;

    // Use this for initialization
    void Start()
    {
        
        ApplicationModel.gameEnd = false;

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        currentLine = ApplicationModel.curLine;
        ApplicationModel.endAtLine = ApplicationModel.endLine;

        if (ApplicationModel.endAtLine == 0)
        {
            ApplicationModel.endAtLine = textLines.Length - 1;
        }

        //Start x & y position of 'Right Touch Box' and width & height of 'Right Touch Box'
        Right.x = 1920 / 2; 
        Right.y = 0;
        Right.width = 1920 / 2;
        Right.height = 1080;

        //Start x & y position of 'Left Touch Box' and width & height of 'Left Touch Box'
        Left.x = 0;
        Left.y = 0;
        Left.width = 1920 / 2;
        Left.height = 1080;
        
        audioSources = gameObject.AddComponent<AudioSource>();
        audioSources.loop = false;

        int temp = SceneManager.GetActiveScene().buildIndex;

        if (temp == 2)  //intro
        {
            btnClips = new AudioClip[65];
            for (int i = 0; i < 65; i++)
            {
                string track = "";

                if (i < 10)
                {
                    track = "Track0" + i;
                }
                else
                {
                    track = "Track" + i;
                }

                btnClips[i] = (AudioClip)Resources.Load("Sounds/part0/" + track);
            }
        }
        else if(temp == 4)  //part 1
        {
            btnClips = new AudioClip[65];
            for (int i = 0; i < 65; i++)
            {
                string track = "";

                if (i < 10)
                {
                    track = "Track0" + i;
                }
                else
                {
                    track = "Track" + i;
                }

                btnClips[i] = (AudioClip)Resources.Load("Sounds/part1/" + track);
            }
        }
        else if (temp == 5) //part 2
        {
            btnClips = new AudioClip[65];
            for (int i = 0; i < 65; i++)
            {
                string track = "";

                if (i < 10)
                {
                    track = "Track0" + i;
                }
                else
                {
                    track = "Track" + i;
                }

                btnClips[i] = (AudioClip)Resources.Load("Sounds/part2/" + track);
            }
        }
        else if (temp == 6) //part 3
        {
            btnClips = new AudioClip[61];
            for (int i = 0; i < 61; i++)
            {
                string track = "";

                if (i < 10)
                {
                    track = "Track0" + i;
                }
                else
                {
                    track = "Track" + i;
                }

                btnClips[i] = (AudioClip)Resources.Load("Sounds/part3/" + track);
            }
        }
        else if (temp == 7) //outro
        {
            btnClips = new AudioClip[17];
            for (int i = 0; i < 17; i++)
            {
                string track = "";

                if (i < 10)
                {
                    track = "Track0" + i;
                }
                else
                {
                    track = "Track" + i;
                }

                btnClips[i] = (AudioClip)Resources.Load("Sounds/part4/" + track);
            }
        }
    }

    void Update()
    {
        if (sideMenu.activeInHierarchy == false)
        {
            ApplicationModel.curScene = SceneManager.GetActiveScene().buildIndex;
            if (ApplicationModel.curScene == 4)
            {
                if (currentLine == 8 || currentLine == 24 || currentLine == 45)
                {
                    if (ApplicationModel.summaryPage == false)
                    {
                        changeScene.load(ApplicationModel.curScene, currentLine);
                        replayBtn.SetActive(true);
                    }
                }
                else
                {
                    replayBtn.SetActive(false);
                }

                if (currentLine == 2)   //select game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(10);
                }
                if (currentLine == 28 || currentLine == 39 || currentLine == 44)    //touch game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(11);
                }
                if (currentLine == 48 || currentLine == 53 || currentLine == 60)    //drag&drop game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    if (currentLine == 48)
                    {
                        Application.LoadLevel(12);
                    }
                    else if (currentLine == 53)
                    {
                        Application.LoadLevel(13);
                    }
                    else if (currentLine == 60)
                    {
                        Application.LoadLevel(14);
                    }
                }
            }
            else if (ApplicationModel.curScene == 5)
            {
                if (currentLine == 16 || currentLine == 23 || currentLine == 45)
                {
                    if (ApplicationModel.summaryPage == false)
                    {
                        changeScene.load(ApplicationModel.curScene, currentLine);
                        replayBtn.SetActive(true);
                    }
                }
                else
                {
                    replayBtn.SetActive(false);
                }

                if (currentLine == 9)   //select game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(9);
                }
                if (currentLine == 32)   //typing game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(11);
                }
                if (currentLine == 49 || currentLine == 56 || currentLine == 62)    //drag&drop game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    if (currentLine == 49)
                    {
                        Application.LoadLevel(15);
                    }
                    else if (currentLine == 56)
                    {
                        Application.LoadLevel(16);
                    }
                    else if (currentLine == 62)
                    {
                        Application.LoadLevel(17);
                    }
                }
            }
            else if (ApplicationModel.curScene == 6)
            {
                if (currentLine == 7 || currentLine == 18 || currentLine == 39)
                {
                    if (ApplicationModel.summaryPage == false)
                    {
                        changeScene.load(ApplicationModel.curScene, currentLine);
                        replayBtn.SetActive(true);
                    }
                }
                else
                {
                    replayBtn.SetActive(false);
                }

                if (currentLine == 5)   //select game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(21);
                }
                if (currentLine == 45 || currentLine == 51 || currentLine == 58)    //drag&drop game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    if (currentLine == 45)
                    {
                        Application.LoadLevel(22);
                    }
                    else if (currentLine == 51)
                    {
                        Application.LoadLevel(23);
                    }
                    else if (currentLine == 58)
                    {
                        Application.LoadLevel(25);
                    }
                }
                if(currentLine == 29)   //typing game
                {
                    ApplicationModel.tempSaveCurLine = currentLine + 1;
                    Application.LoadLevel(11);
                }
            }


            if (currentLine == 0 || currentLine == ApplicationModel.curLine)
            {
                nextArrow.SetActive(true);
                prevArrow.SetActive(false);
            }
            else
            {
                nextArrow.SetActive(true);
                prevArrow.SetActive(true);
            }

            theText.text = textLines[currentLine];


            for (int i = 0; i < Input.touchCount; ++i)
            {

                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    
                    if (Left.Contains(Input.GetTouch(i).position))
                    {
                        if (currentLine == ApplicationModel.curLine)
                        {
                            ApplicationModel.left = 0;
                        }
                        else
                        {
                            wf.write("Previous");
                            currentLine--;
                            ApplicationModel.left = 1;
                            
                            audioRun = false;
                            
                        }
                    }
                    else if (Right.Contains(Input.GetTouch(i).position))
                    {
                        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(i).position)), Vector2.zero);

                        if (hit.collider != null && hit.collider.tag == "replay")
                        {
                            ApplicationModel.curLine = ApplicationModel.replayStart;
                            ApplicationModel.right = 0;
                            ApplicationModel.replayFromScene += 1;
                            Application.LoadLevel(ApplicationModel.curScene);
                        }
                        else
                        {
                            wf.write("Next");
                            currentLine++;
                            ApplicationModel.right = 1;

                            audioRun = false;
                        }
                    }
                    
                }
                
            }
            
            if (currentLine > ApplicationModel.endAtLine)
            {
                textBox.SetActive(false);
                ApplicationModel.partIntro = false;
                ApplicationModel.partOne = false;
                ApplicationModel.partTwo = false;
                ApplicationModel.partThree = false;
                ApplicationModel.partFour = false;
                ApplicationModel.right = 0;
                ApplicationModel.left = 0;

                
                if (ApplicationModel.curScene == 7)
                {
                    ApplicationModel.gameEnd = true;
                    wf.write("GAME CLEAR");
                    Application.LoadLevel(0);
                }
                else
                {
                    if(ApplicationModel.curScene == 2)
                    {
                        ApplicationModel.part1Unlock = true;
                        
                    }
                    else if(ApplicationModel.curScene == 4)
                    {
                        ApplicationModel.part2Unlock = true;
                        
                    }
                    else if (ApplicationModel.curScene == 5)
                    {
                        ApplicationModel.part3Unlock = true;
                       
                    }
                    else if (ApplicationModel.curScene == 6)
                    {
                        ApplicationModel.part4Unlock = true;
                        
                    }

                    Application.LoadLevel(3);
                }
            }
            if (currentLine <= ApplicationModel.endAtLine)
            {
                audioPlay();
            }
        }
    }

    private void audioPlay()
    {
        if(!audioRun)
        {
            audioSources.clip = btnClips[currentLine];
            audioSources.Play();
            audioRun = true;
        }
    }
}
