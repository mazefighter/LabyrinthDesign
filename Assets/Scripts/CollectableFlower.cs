using System;
using TMPro;
using UnityEngine;

public class CollectableFlower : MonoBehaviour
{
    public static int TotalFlowerCount = 0;
    private bool collected;
    [SerializeField] private GameObject visual, collectedVisual;
    private Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
        TotalFlowerCount++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collected) return;
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<FlowerCounter>().incrementFlower();
            collected = true;
            visual.SetActive(false);
            collectedVisual.SetActive(true);
        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0,0,50*Time.deltaTime));
        transform.position = originalPosition + new Vector3(0, Mathf.Sin(Time.time)*.1f, 0);
    }
    
    
}
