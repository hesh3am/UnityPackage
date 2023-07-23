using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Light_Trigger : MonoBehaviour
{
    [SerializeField] private Image reticle;
   // [SerializeField] private Animator myDoor = null;
    [SerializeField] private Light flash1;
    [SerializeField] private Light flash2;
    [SerializeField] private Light flash3;
    [SerializeField] private GameObject player;
    private Light light_turn;
    private bool lightEvent;

    private void Start()
    {
        lightEvent = false;
        reticle.color = new Color(1, 1, 1, 0.75f);
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
               hit.transform.gameObject.CompareTag("light"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            light_Update(flash1);
            pointe_Input();
        }
       else if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
            hit.transform.gameObject.CompareTag("light2"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            light_Update(flash2);
            pointe_Input();
        }
        else if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
          hit.transform.gameObject.CompareTag("light3"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            light_Update(flash3);
            pointe_Input();
        }
        else
        {
            reticle.color = new Color(1, 1, 1, 0.75f);
        }
    }

    private void light_Update(Light x)
    {
        light_turn = x;
    }
    private void pointe_Input()
    {
            if (!lightEvent && Input.GetMouseButtonDown(0))
            {
            light_turn.enabled = false;
            lightEvent = true;
        }
        else if (lightEvent && Input.GetMouseButtonDown(0))
        {
            light_turn.enabled = true;
            lightEvent = false;}
    }
}

