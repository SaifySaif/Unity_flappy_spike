using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movespeed = 5;
    public double deadzone = -92.1;
    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed * Time.deltaTime);
        if (transform.position.x  < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
