using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageControl : MonoBehaviour {

    Animation anim;
    int i = 0;
    List<GameObject> children;

    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animation>();
        //anim.playAutomatically = false;
        children = gameObject.GetChildren();
        
        //Debug.Log(ApplicationModel.curLine);
        if (ApplicationModel.curLine == 0)
        {
            i = ApplicationModel.curLine;
            
        }
        else
        {
            i = ApplicationModel.curLine;
        }
        children[i].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ApplicationModel.right == 1)
        {
            if (i < ApplicationModel.endAtLine)
            {
                children[i].SetActive(false);
                i++;
                children[i].SetActive(true);
                ApplicationModel.right = 0;
            }
        }
        else if (ApplicationModel.left == 1)
        {
            if (i > 0)
            {
                children[i].SetActive(false);
                i--;
                children[i].SetActive(true);
                ApplicationModel.left = 0;
            }
        }

    }
}
