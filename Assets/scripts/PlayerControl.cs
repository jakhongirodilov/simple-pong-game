using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
  
   public float speed = 10f;    
   Rigidbody2D fizik;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) )
        {
                
                fizik.linearVelocity = new Vector2(0, speed);
             
        } 

        else if(Input.GetKey(KeyCode.DownArrow) ){
          
            fizik.linearVelocity = new Vector2(0, -speed);
             
        }   

        else{
            fizik.linearVelocity = new Vector2(0,0);
        }

        fizik.linearVelocity=new Vector2(0,fizik.linearVelocity.y);
    }
}
