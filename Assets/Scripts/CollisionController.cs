using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    [SerializeField] float jumpSpeed;
    private Rigidbody2D rb;
    [SerializeField] Sprite rightJumpDoodle;
    [SerializeField] Sprite leftJumpDoodle;
    private SpriteRenderer sr;
    DoodleController doodleController;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        doodleController = GetComponent<DoodleController>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name=="Green Platform")
        {
            rb.velocity = Vector2.up * jumpSpeed * Time.deltaTime;

            if (sr.sprite==doodleController.leftDoodle)
            {
                sr.sprite = leftJumpDoodle;

            }
            else if (sr.sprite == doodleController.rightDoodle)
            {
                sr.sprite = rightJumpDoodle;
            }
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "Green Platform")
        {
            if (sr.sprite == leftJumpDoodle)
            {
                sr.sprite = doodleController.leftDoodle;

            }
            else if (sr.sprite == rightJumpDoodle)
            {
                sr.sprite = doodleController.rightDoodle;
            }
        }


    }
    
}
