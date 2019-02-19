using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngle : MonoBehaviour
{
    public GameObject ThirdCam;
    public GameObject FirstCam;
    public int Cammode;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Cammode == 1)
            {
                Cammode = 0;
            }
            else
            {
                Cammode += 1;
            }
            StartCoroutine(CameraChange());
        }

    }

    IEnumerator CameraChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (Input.GetKeyDown(KeyCode.I))
        {
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            ThirdCam.SetActive(false);
            FirstCam.SetActive(true);
        }
    }
}