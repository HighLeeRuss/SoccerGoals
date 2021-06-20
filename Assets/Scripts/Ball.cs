using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Transform endPos;
    private bool shoot = false;
    private bool takenShot = false;
    private Vector3 respawn;


    private void Start()
    {
        respawn = gameObject.transform.position;
        //respawn = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }


    private void Update()
   {
       if (Input.GetKeyDown(KeyCode.E) && !takenShot)
       {
           //transform.position = Vector3.Lerp(transform.position, endPos.position, speed);
           shoot = true;
       }

       if (shoot)
       {
           transform.position = Vector3.MoveTowards(transform.position,endPos.position,0.1f);
          if(Vector3.Distance(this.transform.position,endPos.position) < 0.1f)
          {
              shoot = false;
              takenShot = true;
              if (takenShot)
              {
                  Reset();
              }
          }
       }


   }

    private void Reset()
    {
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4f);
        gameObject.transform.position = respawn;
        takenShot = false;


    }
}
