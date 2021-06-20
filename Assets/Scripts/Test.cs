using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour


{

    public GameObject ball;
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            Debug.Log("goal");
            EventManager.ActivateFalling();
            EventManager.ActivateScore();
            EventManager.ActivateReset();
        }
    }
}
