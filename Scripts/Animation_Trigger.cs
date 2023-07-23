using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Trigger : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger=false;

private void OnTriggerEnter(Collider other)
    {
        myDoor.Play("opendoor", 0, 0.0f);
        /*       if (other.CompareTag("Player"))
               {
                   if (openTrigger)
                   {
                       myDoor.Play("opendoor", 0, 0.0f);
                       gameObject.SetActive(false);
                   }
                   else if (closeTrigger)
                   {
                       myDoor.Play("closedoor", 0, 0.0f);
                       gameObject.SetActive(false);
                   }

               }*/
    }
    private void OnTriggerExit(Collider other)
    {

        myDoor.Play("closedoor", 0, 0.0f);
    }
}
