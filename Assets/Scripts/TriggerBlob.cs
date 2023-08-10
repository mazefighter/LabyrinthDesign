using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlob : MonoBehaviour
{
    [SerializeField] private GameObject blob;
    private bool Triggered = true;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Triggered)
        {
            blob.GetComponent<Animator>().SetTrigger("Walk");
            Triggered = false;
        }
    }
}
