using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraCTRL : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    GameObject player;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Camera.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Camera.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.P))
        {
            Camera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Camera4.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.U))
        {
            Camera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            Camera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(true);
            Camera6.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            Camera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(true);
        }
        transform.LookAt(target);
    }
}
