using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideMenuManager : MonoBehaviour {

    writeFile wf = new writeFile();
    

	public void loadMain() {
        ApplicationModel.partIntro = false;
        ApplicationModel.partOne = false;
        ApplicationModel.partTwo = false;
        ApplicationModel.partThree = false;
        ApplicationModel.partFour = false;

        ApplicationModel.startorNot = false;

        ApplicationModel.addIn = true;
        ApplicationModel.fileNumb++;
        wf.write("VIA SIDEMENU TO MAIN MENU");
        ApplicationModel.reset();
        loadLvl (0);
	}
		
    public void loadSceneSelectFromMain()
    {
        ApplicationModel.partIntro = false;
        ApplicationModel.partOne = false;
        ApplicationModel.partTwo = false;
        ApplicationModel.partThree = false;
        ApplicationModel.partFour = false;

        ApplicationModel.startorNot = true;
        wf.write("VIA MAIN MENU TO SELECT MENU");
        loadLvl(1);
    }

	public void loadsceneSelect() {
        ApplicationModel.partIntro = false;
        ApplicationModel.partOne = false;
        ApplicationModel.partTwo = false;
        ApplicationModel.partThree = false;
        ApplicationModel.partFour = false;

        ApplicationModel.startorNot = true;

        ApplicationModel.addIn = true;
        ApplicationModel.fileNumb++;
        wf.write("VIA SIDEMENU TO SELECT MENU");
        ApplicationModel.reset();
        loadLvl (1);
	}

    public void timerStop ()
    {
        ApplicationModel.partIntro = false;
        ApplicationModel.partOne = false;
        ApplicationModel.partTwo = false;
        ApplicationModel.partThree = false;
        ApplicationModel.partFour = false;

        ApplicationModel.startorNot = false;
    }

    public void timerRestart()
    {
        if (ApplicationModel.curScene == 2 && ApplicationModel.summaryPage == false)
        {
            ApplicationModel.partIntro = true;
        }
        else if (ApplicationModel.curScene == 4 && ApplicationModel.summaryPage == false)
        {
            ApplicationModel.partOne = true;
        }
        else if (ApplicationModel.curScene == 5 && ApplicationModel.summaryPage == false)
        {
            ApplicationModel.partTwo = true;
        }
        else if (ApplicationModel.curScene == 6 && ApplicationModel.summaryPage == false)
        {
            ApplicationModel.partThree = true;
        }
        else if (ApplicationModel.curScene == 7 && ApplicationModel.summaryPage == false)
        {
            ApplicationModel.partFour = true;
        }

        ApplicationModel.startorNot = true;
    }

	public void quitProc() {
		Application.Quit ();
	}

	private void loadLvl (int lvl) {
        ApplicationModel.summaryPage = false;

        
        Application.LoadLevel (lvl);
	}



}
