using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Trigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject enemy;
    public GameObject signObject;

   private bool activated=false;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I'm the trigger, someone has enter");

       if (other.tag == "Player") {

            signObject.SetActive(true);
            enemy.SetActive(true);

            // if (!activated)
            // {
            //     activated = true;

            //     audioSource.enabled=true;
            //     enemy.SetActive(true);
            // }
        }

    }

    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit Event");
        if (other.tag == "Player")
        {

            enemy.SetActive(false);
            signObject.SetActive(false);
            
        }


    }
}
