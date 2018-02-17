using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class writeFile : MonoBehaviour
{

    public void write(string msgInput)
    {
        string DIR_PATH = Application.persistentDataPath + "/dir_" + ApplicationModel.dirNumb;

        try
        {
            if (Directory.Exists(DIR_PATH))
            {
                if (File.Exists(Application.persistentDataPath + "/gameData.txt"))
                {
                    string text = System.IO.File.ReadAllText(Application.persistentDataPath + "/gameData.txt");
                    string[] word = text.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    int temp_dirNumb = 0;
                    //Debug.Log(word.Length);
                    Int32.TryParse(word[word.Length - 2], out temp_dirNumb);

                    if (ApplicationModel.dirNumb <= temp_dirNumb)
                    {
                        while (ApplicationModel.dirNumb <= temp_dirNumb)
                        {
                            ApplicationModel.dirNumb++;
                        }
                    }
                    DIR_PATH = Application.persistentDataPath + "/dir_" + ApplicationModel.dirNumb;
                }
            }
            Directory.CreateDirectory(DIR_PATH);    //will be ignored when its already exists
        }
        catch (IOException ex)
        {
            Debug.Log(ex.Message);
        }

        string FILE_PATH = DIR_PATH + "/file_" + ApplicationModel.fileNumb + ".txt";
        //fileNumb will be increased when player pressed menu buttons

        //if (File.Exists(FILE_PATH))
        //{
        //    while (File.Exists(FILE_PATH))
        //    {
        //        ApplicationModel.fileNumb++;
        //        FILE_PATH = DIR_PATH + "/file_" + ApplicationModel.fileNumb + ".txt";
        //    }
        //}
        //StreamWriter sr = System.IO.File.CreateText(FILE_PATH);
        StreamWriter sr = new StreamWriter(FILE_PATH, true, Encoding.UTF8);
        System.DateTime time = System.DateTime.Now;

        sr.Write(msgInput + ", " + ApplicationModel.curScene + ", " + time.ToString("yyy-MM-dd-HH-mm-ss") + ", " + ApplicationModel.timer + ", " + ApplicationModel.timer0 + ", " + ApplicationModel.timer1
            + ", " + ApplicationModel.timer2 + ", " + ApplicationModel.timer3 + ", " + ApplicationModel.timer4 + ", " + ApplicationModel.gameEnd + ", " + ApplicationModel.overallAttemptsinALL
            + ", " + ApplicationModel.attemptPart1Quiz1 + ", " + ApplicationModel.attemptPart1Quiz2 + ", " + ApplicationModel.attemptPart1Quiz3
            + ", " + ApplicationModel.scorePart1Quiz1 + ", " + ApplicationModel.scorePart1Quiz2 + ", " + ApplicationModel.scorePart1Quiz3
            + ", " + ApplicationModel.attemptPart2Quiz1 + ", " + ApplicationModel.attemptPart2Quiz2 + ", " + ApplicationModel.attemptPart2Quiz3
            + ", " + ApplicationModel.scorePart2Quiz1 + ", " + ApplicationModel.scorePart2Quiz2 + ", " + ApplicationModel.scorePart2Quiz3
            + ", " + ApplicationModel.attemptPart3Quiz1 + ", " + ApplicationModel.attemptPart3Quiz2 + ", " + ApplicationModel.attemptPart3Quiz3
            + ", " + ApplicationModel.scorePart3Quiz1 + ", " + ApplicationModel.scorePart3Quiz2 + ", " + ApplicationModel.scorePart3Quiz3
            + ", " + ApplicationModel.overallAttemptPart1Quiz + ", " + ApplicationModel.overallAttemptPart2Quiz + ", " + ApplicationModel.overallAttemptPart3Quiz
            + ", " + ApplicationModel.overallScorePart1Quiz + ", " + ApplicationModel.overallScorePart2Quiz + ", " + ApplicationModel.overallScorePart3Quiz
            + ", " + ApplicationModel.overallScore + ", " + ApplicationModel.replayFromSummary + ", " + ApplicationModel.replayFromScene + Environment.NewLine);
        sr.Close();
    }
    //sceneNumber, realTime, overall time, time intro - outro, gameEnd, overallAttemptsinAll, attempt&score 1 - 3

    void OnApplicationQuit()
    {
        write("QUIT APP");

        string FILE_PATH2 = Application.persistentDataPath + "/gameData.txt";

        //StreamWriter sr = System.IO.File.CreateText(FILE_PATH2);
        //sr.WriteLine(ApplicationModel.dirNumb +"," + ApplicationModel.fileNumb);

        StreamWriter sr2 = new StreamWriter(FILE_PATH2, true, Encoding.UTF8);
        sr2.Write(ApplicationModel.dirNumb + "," + ApplicationModel.fileNumb + Environment.NewLine);
        sr2.Close();
    }
}
