using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    
    private void OnEnable()
    {
        EventManager.ScoreActivated += AddScore;
    }

    private void OnDisable()
    {
        EventManager.ScoreActivated -= AddScore;
    }

    void AddScore()
    {
        score++;
        print("Red Team has scored, the score is now " + score + ".");
    }
    
}
