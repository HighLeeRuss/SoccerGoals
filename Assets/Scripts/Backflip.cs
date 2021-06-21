using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Backflip : MonoBehaviour
{
    public Vector3 axis = new Vector3(0,0,1);
    public float degrees = 360f;
    public float timespan = 1f;

    private float rotated = 0;
    private Vector3 rotationVector;

    private Renderer rend;

    
    






    // Start is called before the first frame update
   void Start()
   {
       axis.Normalize();
       rotationVector = axis * degrees;
       rend = GetComponent<Renderer>();


   }

   // Update is called once per frame
   void Update()
   {
       rotated += degrees * (Time.deltaTime / timespan);
       if (degrees > rotated)
       {
           transform.Rotate(rotationVector * (Time.deltaTime / timespan));
       }
       rend.material.SetColor("_Color", Color.magenta);
   }
 
}
