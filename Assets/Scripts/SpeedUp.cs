using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private float speedUp = 2;
    private ObjectPool objectPool;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    
    void Update()
    {
        
    }
}
