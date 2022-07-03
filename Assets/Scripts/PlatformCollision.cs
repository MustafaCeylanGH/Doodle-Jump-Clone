using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    private float jumpSpeed = 350;
    private GameObject doodle;
    private Rigidbody2D rb;       
    
    private void Start()
    {
        doodle = GameObject.FindGameObjectWithTag("Doodle");
        rb = doodle.GetComponent<Rigidbody2D>();    
    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Doodle"))
        {
            
            if (other.relativeVelocity.y<=0)
            {               
                rb.velocity = Vector2.up * jumpSpeed * Time.deltaTime;                
            }                                  

        }

        if (other.gameObject.tag == "Platform")
        {           
            Destroy(gameObject);
        }

    }
}
