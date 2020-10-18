using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;
[Serializable]

public class UserData
{
    public float userTime;
    public string userCurrentLevel;
    public string userButtonPressed;
    public bool userCorrect;
    public int userInputCount;

    public UserData(float tim, string curLev, string butPres, bool corr, int coun)
    {
        userTime = tim;
        userCurrentLevel = curLev;
        userButtonPressed = butPres;
        userCorrect = corr;
        userInputCount = coun;
    }
}

