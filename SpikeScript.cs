using System;
using System.Collections; 
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    //*void indicates no value is being returned

    public Rigidbody2D myRigidbody; //public variable means variable is visible to all classes. So here the variable "myRigidbody" will be visible to all classes. C# uses camelCase to name variables.
    public float flapStrength; // Unlike python we have to explicitly specify the datatype of the variable
    public float dashStrength;
    public bool isSpikeAlive = true;
    void Update() //Update is called once per frame.
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isSpikeAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; //Vector2 describes x and y position of game object.
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true && isSpikeAlive == true)
        {   
            myRigidbody.velocity = Vector2.right * dashStrength;
        }

        if (transform.position.x <= -169 || transform.position.x >= 82 || transform.position.y <= -100 || transform.position.y >= 100)
        {
            logic.gameOver();
            isSpikeAlive = false;
        }
    }

  

}
