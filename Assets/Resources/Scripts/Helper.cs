﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper
{

    public static List<GameObject> GetChildren(this GameObject go)
    {
        List<GameObject> children = new List<GameObject>();
        foreach (Transform tran in go.transform)
        {
            children.Add(tran.gameObject);
        }
        return children;
    }
}
