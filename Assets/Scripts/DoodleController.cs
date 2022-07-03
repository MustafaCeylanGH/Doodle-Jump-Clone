using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleController : MonoBehaviour
{      
    [SerializeField] public Sprite leftDoodle;
    [SerializeField] public Sprite rightDoodle;
    private SpriteRenderer sr;
    [SerializeField] float doodleMoveSpeed = 2.0f;
    private float horizontalInput;    
    private float xBoundary = 3.15f;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        DoodleMove();
        DoodleBoundary();
    }

    private void DoodleMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        SpriteControl();
        transform.Translate(doodleMoveSpeed * Time.deltaTime*horizontalInput, 0,0);
    }

    private void DoodleBoundary()
    {
        if (transform.position.x >= xBoundary)
        {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);

        }else if(transform.position.x <= -xBoundary)
        {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }
    }

    private void SpriteControl()
    {
        if (horizontalInput < 0)
        {
            sr.sprite = leftDoodle;
        }
        else if (horizontalInput > 0)
        {
            sr.sprite = rightDoodle;
        }
        else
        {
            this.sr.sprite = sr.sprite;
        }
    }
}
