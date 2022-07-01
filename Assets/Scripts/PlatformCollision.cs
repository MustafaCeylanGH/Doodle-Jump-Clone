using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 5;
    [SerializeField] GameObject doodle;
    private Rigidbody2D rb;
    private BoxCollider2D bc2d;

    private void Start()
    {
        rb = doodle.GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Doodle")
        {
            rb.velocity = Vector2.up * jumpSpeed * Time.deltaTime;
            bc2d.isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bc2d.isTrigger = false;
    }


}
