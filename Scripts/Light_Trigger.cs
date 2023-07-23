using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Light_Trigger : MonoBehaviour
{
    [SerializeField] private Light flash;
    [SerializeField] private GameObject player;
    [SerializeField] private float distanceInteract;
    private bool lightEvent;

    private void Start()
    {
        lightEvent = false;
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
            if (!lightEvent)
            {
            flash.enabled = false;
            lightEvent = true;
        }
        else if (lightEvent)
        {
            flash.enabled = true;
            lightEvent = false;}
    }
}
// Input.GetMouseButtonDown(0)
