using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{

    public delegate void OposingTeamFall();
    public static event OposingTeamFall FallingActivated;

    static public void ActivateFalling()
    {
        FallingActivated();
    }

    
    public delegate void ScoreIncrease();

    public static event ScoreIncrease ScoreActivated;

    static public void ActivateScore()
    {
        ScoreActivated();
    }

    
    public delegate void BlueTeamReset();

    public static event BlueTeamReset ResetAcitvated;

    static public void ActivateReset()
    {
        ResetAcitvated();
    }

    public event Action Test;

    public void Update()
    {
        if (Test != null)
        {
            Test();
        }
    }
}
