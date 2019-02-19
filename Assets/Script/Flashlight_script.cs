using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_script : MonoBehaviour
{
    public Light flashlight;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == false)
        {
            flashlight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && flashlight == true)
        {
            flashlight.enabled = false;
        }

    }
}
