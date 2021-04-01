using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using System;

public class ObjectPool : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float Speed
    {
        get { return speed; }
   
    }
    private float[] prefabString = new float[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
    private float[] prefabRow = new float[] { -2.5f, -2f, -1.5f, -1f, -0.5f, 0f, 0.5f, 1f, 1.5f, 2f, 2.5f };
    private int[] platformsCount = new int[10];
    [SerializeField] private GameObject playerTrigger;
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject chunkSpawn;
    [SerializeField] private GameObject speedUpZone;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        { 
           gameObject.transform.position = new Vector2(0f, 10.31f);
         for (int i = 0; i < 11; i++)
         {
            //System.Random r = new System.Random();
            Instantiate(platformPrefab, new Vector3(prefabRow[UnityEngine.Random.Range(0,10)],10.31f + col.gameObject.transform.position.y + prefabString[UnityEngine.Random.Range(0, 11)], 10), Quaternion.identity);
           // r = null;
         }
            //Destroy(gameObject);
            
        }
      
    }

    

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

}
