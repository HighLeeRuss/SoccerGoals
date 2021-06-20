using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private float speed = 1f;


    private void OnEnable()
    {
        EventManager.FallingActivated += Falling;
    }

    private void OnDisable()
    {
        EventManager.FallingActivated -= Falling;
    }


    void Falling()
    {
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1f);
        transform.Rotate(90f, 0f, 0f  * Time.deltaTime); 
    }
    
}
