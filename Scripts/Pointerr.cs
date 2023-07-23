using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointerr : MonoBehaviour
{
    [SerializeField] private Image reticle;
    [SerializeField] private GameObject player;
    [SerializeField] private float distanceInteract;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, distanceInteract) &&
         (hit.transform.gameObject.CompareTag("door")
          || hit.transform.gameObject.CompareTag("light")
          || hit.transform.gameObject.CompareTag("cube")))
        {
            reticle.color = new Color(0, 1, 0, 0.75f);
            reticle.enabled = true;
        }
        else
            reticle.enabled = false;
    }
}
