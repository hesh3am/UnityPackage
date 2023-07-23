using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_gerated : MonoBehaviour
{
    public AudioSource tickSource ;
    void Start()
    {
       // tickSource = GetComponent<AudioSource>();
    } 
      private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player") {
      tickSource.Play();
      gameObject.SetActive(false);
        }
    }                                         
}
