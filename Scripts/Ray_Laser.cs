using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Laser : MonoBehaviour
{
    private MeshRenderer targetCube;
    public GameObject sphere;
 private void Update()
    {
        RaycastHit hit;
 if (Physics.Raycast(transform.position,transform.right, out hit, 50f) )
        {
            targetCube = hit.collider.GetComponent<MeshRenderer>();
            targetCube.material.color = Color.red;
        }
 else
        {
            if(targetCube != null)
                targetCube.material.color = Color.blue;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.right * 50 );
    }
}
