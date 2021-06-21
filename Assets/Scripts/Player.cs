using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    //private float speed = 100f;
    public Vector3 axis = new Vector3(0,0,1);
    public float degrees = 90f;
    public float timespan = 1f;

    private float rotated = 0;
    private Vector3 rotationVector;
    
    void Start()
    {
        axis.Normalize();
        rotationVector = axis * degrees;
    }

    


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
        rotated += degrees * (Time.deltaTime / timespan);
        if (degrees > rotated)
        {
            transform.Rotate(rotationVector * (Time.deltaTime / timespan));
        }
      
    }
    
    
}
