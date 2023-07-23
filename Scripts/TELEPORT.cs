using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT : MonoBehaviour
{
    public Transform tb;
   // public GameObject player;
    public int direction;

    private void OnTriggerEnter(Collider other)
    {
        // Transform();
        StartCoroutine(Transport_tb(other));
    }

     IEnumerator Transport_tb(Collider other)
    {
        yield return new WaitForSeconds(0.00001f);
        other.transform.position = new Vector3(
            tb.transform.position.x,
            tb.transform.position.y,
            tb.transform.position.z + direction);
    }
}
