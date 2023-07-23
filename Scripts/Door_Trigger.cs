using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Door_Trigger : MonoBehaviour
{
    [SerializeField] private Animator door;
    [SerializeField] private GameObject player;
    [SerializeField] private float distanceInteract;
    bool doorEvent ;
    private void Start()
    {
        doorEvent = false;
    }
    private void OnMouseDown()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, distanceInteract))
        {
            pointe_Input();
        }
    }
    private void pointe_Input()
    {
        if (!doorEvent)
        {
            door.Play("opendoor", 0, 0.0f);
            doorEvent = true;
        }
        else if (doorEvent)
        {
            door.Play("closedoor", 0, 0.0f);
            doorEvent = false;
        }
    }
}

// Input.GetMouseButtonDown(0)
