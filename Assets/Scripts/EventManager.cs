using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void OposingTeamFall();
    public static event OposingTeamFall FallingActivated;

    static public void ActivateFalling()
    {
        FallingActivated();
    }

}