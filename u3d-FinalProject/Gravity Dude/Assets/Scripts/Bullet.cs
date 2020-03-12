using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed=20f;
    public Rigidbody2D rb;
    public GameObject player1;
    public GameObject player2;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit: " + collision.name);
        if (collision.CompareTag("Block"))
        {
            Debug.Log("BlockHit!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player1")) {
            Debug.Log("hit player one");
            Player1 hitPlayer1=collision.GetComponent<Player1>();
            Destroy(gameObject);
            hitPlayer1.TakeDamage(10);
            //@PENDIENTE cambiar posicion al inicio de la camara
        }

        if (collision.CompareTag("Player2"))
        {
            Debug.Log("hit player two");
            Destroy(gameObject);
            Player2 hitPlayer2 = collision.GetComponent<Player2>();
            hitPlayer2.TakeDamage(10);
            //@PENDIENTE cambiar posicion al inicio de la camara
        }

        //so that bullets wont go further from the border
        if(collision.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 3);
        }
    }
    // Update is called once per frame
}
