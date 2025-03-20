using UnityEngine;
using System.Collections.Generic;
using System.Collections;

// Quits the player when the user hits escape

public class QuitScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}