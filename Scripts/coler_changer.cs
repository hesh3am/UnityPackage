using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coler_changer : MonoBehaviour
{
    public float hoverForce = 10f;
    public Color m_oldColor = Color.white;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.red;
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is within trigger");
        //Renderer render = GetComponent<Renderer>();
       // m_oldColor = render.material.color;
        //render.material.color = Color.green;
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Exited the trigger");
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }

}
