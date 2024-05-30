using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuyin : MonoBehaviour
{
    public AudioSource ad;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            ad.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ad.Stop();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
