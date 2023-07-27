using System;
using UnityEngine;

public class CollectableFlower : MonoBehaviour
{
    public static int CollectedFlowerCount = 0;
    private bool collected;
    [SerializeField] private GameObject visual, collectedVisual;
    private Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collected) return;
        if (other.gameObject.CompareTag("Player"))
        {
            collected = true;
            CollectedFlowerCount++;
            visual.SetActive(false);
            collectedVisual.SetActive(true);
        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0,50*Time.deltaTime,0));
        transform.position = originalPosition + new Vector3(0, Mathf.Sin(Time.time)*.05f, 0);
    }
}
