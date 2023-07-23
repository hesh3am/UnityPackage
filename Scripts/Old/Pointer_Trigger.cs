using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pointer_Trigger : MonoBehaviour
{
     [SerializeField] private Image reticle;
    [SerializeField] private Animator myDoor = null;
        [SerializeField] private Light light;


    private void Start()
    {
        reticle.color = new Color(1, 1, 1, 0.75f);
    }

    private void Update()
    {
        RaycastHit hit;
               if  (Physics.Raycast(transform.position, transform.forward, out hit, 50f) && 
               hit.transform.gameObject.CompareTag("door") )
        {
              reticle.color = new Color(0, 1, 0, 0.75f);
                 if (Input.GetMouseButtonDown(0))
               { Debug.Log("Pressed primary button.");
                myDoor.Play("opendoor", 0, 0.0f);
               }
              else if (Input.GetMouseButtonDown(1))
               { Debug.Log("Pressed primary button.");
                myDoor.Play("closedoor", 0, 0.0f);
               }
        }

               else if (Physics.Raycast(transform.position, transform.forward, out hit, 50f) && 
               hit.transform.gameObject.CompareTag("enemy"))
        {
                reticle.color = new Color(1, 0, 0, 0.75f);
        }
               else if (Physics.Raycast(transform.position, transform.forward, out hit, 50f) && 
               hit.transform.gameObject.CompareTag("light"))
        {
             reticle.color = new Color(0, 1, 0, 0.75f);
            if (Input.GetMouseButtonDown(0))
               { light.enabled = true;}
            else if (Input.GetMouseButtonDown(1))
               {light.enabled = false;}        
               }

        else
        {
            reticle.color = new Color(1, 1, 1, 0.75f);
        }
 
   }
}
