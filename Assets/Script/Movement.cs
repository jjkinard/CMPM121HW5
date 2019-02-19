using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed=10;
    float rotSpeed= 80;
    float gravity =8;
    float rot = 0f;
    public GameObject pickupEffect;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            else
            {
                anim.SetInteger("condition",0);
                moveDir = new Vector3(0, 0, 0);
            }
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

        if(GameVariables.count == 11)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnTriggerStay(Collider other)
    {
         if (Input.GetKey(KeyCode.E) && other.gameObject.CompareTag("Pick Up"))
         {
                other.gameObject.SetActive(false);
            Instantiate(pickupEffect, transform.position, transform.rotation);
                gameObject.GetComponent<Animator>().Play("pickup");
                GameVariables.count = GameVariables.count + 1;
                

        }
    }
}
