using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic; // making the LogicScript.cs file public to be used in line 24 of the this file's code. I'm getting the addscore function from LogicScript.cs file.

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // As soon as a pipe spawns, this line will look through Unity's hierarchy to find a game object with the tag "Logic", then the .GetComponent will look through the object's components to find the component named "LogicScript"
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore();
        }
    }
}
