using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D fizik;

    public float ballSpeed=100f;
   
    AudioSource ses;
    void Start()
    {
        Invoke("goBall",1);
        ses= GetComponent<AudioSource>();
        fizik = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag=="Player")
        {

            fizik.linearVelocity =  new Vector2(fizik.linearVelocity.x, fizik.linearVelocity.y/2 +5+ col.collider.GetComponent<Rigidbody2D>().linearVelocity.y/3);
            ses.pitch=Random.Range(0.8f,1.2f);
            ses.Play();
        }
    }
    
     void Update() {
        float xVel = fizik.linearVelocity.x;
        if (xVel < 18 && xVel >-18 && xVel!= 0)
        {
            if (xVel>0)
            {
                fizik.linearVelocity=new Vector2(20,fizik.linearVelocity.y);
            }
            else {
                fizik.linearVelocity = new Vector2(-20,fizik.linearVelocity.y);
            }
            
        

        }   

    }

    void goBall(){
         fizik = GetComponent<Rigidbody2D>();
        float randomNumber = Random.Range(0f,1f);
        if (randomNumber<=0.5)
        {
               fizik.AddForce(new Vector2(ballSpeed,10f));
        }
        else{
            fizik.AddForce(new Vector2(-ballSpeed,-10f));
        }
    }

    public void resetBall(){
        fizik.linearVelocity=new Vector2(0,0);
        fizik.transform.position=new Vector2(0,0);

        Invoke("goBall",1);
    }
}
