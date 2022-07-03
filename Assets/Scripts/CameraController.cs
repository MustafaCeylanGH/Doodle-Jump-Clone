using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject Doodle;
 
    private void LateUpdate()
    {
        if (Doodle.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Doodle.transform.position.y,transform.position.z);
        }
        
    }
}
