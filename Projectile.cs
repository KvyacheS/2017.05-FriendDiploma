using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public int damage = 1;
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.CompareTag("Aliens"))
        {
            collision.gameObject.GetComponent<Health>().doDamage(damage);
            Destroy(gameObject);
        }
        else
        {
           Debug.Log("Byebye");
            if (collision.gameObject.CompareTag("Robots"))
            {
                Debug.Log("Byebye2");
                GetComponent<Rigidbody2D>().position += new Vector2(collision.gameObject.GetComponent<BoxCollider2D>().size.x, 0);
               // gameObject.transform.position.x += collision.gameObject.GetComponent<BoxCollider2D>().size.x;
               // collision.gameObject.transform.position
                   // GetComponent<BoxCollider2D>().isTrigger = true;
                
            }
        }
    }
    private void Update()
    {
        if( gameObject.transform.position.x >= 6.5)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        /* if (collision.gameObject.CompareTag("Robots"))
        {
            collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        */
    }
}
