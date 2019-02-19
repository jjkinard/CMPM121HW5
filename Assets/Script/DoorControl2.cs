using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl2 : MonoBehaviour
{
    private Animator Anime;

    private void Start()
    {
        Anime = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Anime.SetBool("bol", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Anime.SetBool("bol", false);
        }
    }
}