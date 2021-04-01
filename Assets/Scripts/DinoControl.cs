using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class DinoControl : MonoBehaviour
{
    public GameObject LeftSide;
    public GameObject RightSide;
    public Rigidbody2D rigidbody;
    public float force;
    public float speed;
    public GameObject MainCamera;
    public GameObject CameraTrigger;
    [SerializeField] private SpriteRenderer sprite;
    private Vector3 direction;

    //Прыжки динозавра
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Platform"))
        rigidbody.velocity = new Vector2(0, 0);
        rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
    //переход из края в край
    private void OnTriggerEnter2D(Collider2D collider)
    {
        float z = -10;
        float x = 0;
      
            if (collider.name == "LeftSide")
            {
                gameObject.transform.position = new Vector3(RightSide.transform.position.x - 1, gameObject.transform.position.y, x);
            }  
            else if (collider.name == "RightSide")
            {
                gameObject.transform.position = new Vector3(LeftSide.transform.position.x + 1, gameObject.transform.position.y, x);
            }
        
    }

    private void FixedUpdate()
    {
        direction = Vector3.zero;                                                                  
            if (Input.GetKey(KeyCode.Mouse0))
            {
            
                if (Input.mousePosition.x <= 556)
                {
                    rigidbody.transform.Translate(Vector2.left * speed * Time.deltaTime);
                direction = Vector3.left;
                }
                else if (Input.mousePosition.x > 556)
                {
                    rigidbody.transform.Translate(Vector2.right * speed * Time.deltaTime);
                    direction = Vector3.right;
                }
             }
            if (direction.x > 0)
                sprite.flipX = false;
            if(direction.x < 0)
                sprite.flipX = true;
            direction *= speed;
            direction.y = rigidbody.velocity.y;
            rigidbody.velocity = direction;
     }



}

