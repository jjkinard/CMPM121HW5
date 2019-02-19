using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    public GameObject PS1;
    public GameObject PS2;
    public GameObject PS3; 
    private void OnTriggerEnter(Collider collider)
    {
        if( collider.gameObject.name == "free_male_1" && GameVariables.keyCount>0)
        {
            GameVariables.keyCount--;
            Destroy(gameObject);
            Instantiate(PS1, transform.position, transform.rotation);
            Instantiate(PS2, transform.position, transform.rotation);
            Instantiate(PS3, transform.position, transform.rotation);
        }
    }
}
