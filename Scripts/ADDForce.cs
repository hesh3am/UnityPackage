using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADDForce : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 3000;
    // Start is called before the first frame update
    void Start()
    {
      //  rb.AddForce(0, 0, 400);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0, 0, speed * Time.deltaTime);
    }
}
