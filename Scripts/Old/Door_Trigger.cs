using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Door_Trigger : MonoBehaviour
{
    [SerializeField] private Image reticle;
    private Animator door_turn;
    [SerializeField] private Animator door1 = null;
    [SerializeField] private Animator door2 = null;
    [SerializeField] private Animator door3 = null;
    [SerializeField] private GameObject player;
    bool doorEvent ;
    private void Start()
    {
        doorEvent = false;
        reticle.color = new Color(1, 1, 1, 0.75f);
    }
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
               hit.transform.gameObject.CompareTag("door"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            Door_Update(door1);
            pointe_Input();
        }
       else if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
            hit.transform.gameObject.CompareTag("door2"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            Door_Update(door2);
            pointe_Input();
        }
        else if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, 50f) &&
          hit.transform.gameObject.CompareTag("door3"))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            Door_Update(door3);
            pointe_Input();
        }
        else
        {
            reticle.color = new Color(1, 1, 1, 0.75f);
        }
    }

    private void Door_Update(Animator x)
    {
        door_turn = x;
    }
    private void pointe_Input()
    {
        
        if (!doorEvent && Input.GetMouseButtonDown(0))
        {door_turn.Play("opendoor", 0, 0.0f);
            doorEvent = true;
        }
        else if  (doorEvent && Input.GetMouseButtonDown(0))
        {door_turn.Play("closedoor", 0, 0.0f);
            doorEvent = false;
        }
    }
}

