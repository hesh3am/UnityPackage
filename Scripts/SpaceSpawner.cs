using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSpawner : MonoBehaviour {

    public bool spawnAtStart;
    public GameObject spawnObject;
    public Transform locationOfSpwan;

    void Start () {
        Debug.Log ("Press Space to spawn cubes");
        if (spawnAtStart) {
            Spawn ();
        }
    }

    void Update () {
        if (Input.GetKeyDown (KeyCode.Space)) {
            Spawn ();
        }
    }

    void Spawn () {
        Instantiate (spawnObject, locationOfSpwan.position, Quaternion.identity);
    }


}