using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlowerCounter : MonoBehaviour
{
    private int Counter;
    
    [SerializeField] private TextMeshProUGUI tmp;
    void Start()
    {
        tmp.text = Counter + "/" + CollectableFlower.TotalFlowerCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void incrementFlower()
    {
        Counter++;
        tmp.text = Counter + "/" + CollectableFlower.TotalFlowerCount;
    }
}
