using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    //private float speed = 100f;


    


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
        //transform.Rotate(90f, 0f, 0f * Time.deltaTime); this is janky
        //Rotate(); this sucks and seems to just do what above does ^
        transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(90f, 0f, 0f), Time.time);
    }

   //void Rotate()
   //{
   //    var oldRotation = transform.rotation;
   //    transform.Rotate(90, 0,0);
   //    var newRoation = transform.rotation;

   //    for (float t = 0.0f; t <= 1.0f; t += Time.deltaTime)
   //    {
   //        transform.rotation = Quaternion.Slerp(oldRotation, newRoation, t * speed);
   //    }

   //    transform.rotation = newRoation;
   //}
    
}
