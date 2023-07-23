using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivvokeSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform locationOfSpwan;
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);

       // newLocation.position = new Vector3(x, newLocation.position.y, z);


    Instantiate(spawnObject, new Vector3(locationOfSpwan.position.x + x, locationOfSpwan.position.y, locationOfSpwan.position.z + z), Quaternion.identity);
    }
}
