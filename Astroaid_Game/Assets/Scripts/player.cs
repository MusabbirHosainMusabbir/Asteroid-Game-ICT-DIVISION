using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10.0f;
   
   
    void Update()
    {
        
       // float moveUpDown = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveLeftRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

       
       // transform.Translate(0, 0, moveUpDown);
        transform.Translate(moveLeftRight , 0, 0);

        

    }
 
     




}