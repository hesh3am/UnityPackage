using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT_Raycast : MonoBehaviour
{
    public Transform tb;
    private Rigidbody rb;
    public GameObject player;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.right, out hit, 5))
        {
            //tb = hit.collider.transform;
            StartCoroutine(Transport_tb());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Transform();
        //StartCoroutine(Transport_tb());
    }

     IEnumerator Transport_tb()
    {
        yield return new WaitForSeconds(0.00001f);
        player.transform.position = new Vector3(
            tb.transform.position.x,
            tb.transform.position.y,
            tb.transform.position.z);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.right * 5);
    }
}
