using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone"))
            Destroy(gameObject);
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
