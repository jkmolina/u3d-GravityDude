using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int hp = 100;
    public GameObject jugador1;
    public int xPosition;
    public int yPosition;
    public int xspeed;
    public int yspeed;
    public Rigidbody2D rb;
    Vector2 pos;
    public bool isGrounded;
    public bool touchesEnemy;
    void Start()
    {
        Vector2 pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempScale = transform.localScale;
        GetComponent<Rigidbody2D>().velocity = new Vector2(xspeed, yspeed);
        if (isGrounded)
        {
            changeYourGravity();
        }
        if(touchesEnemy)
        {
            changeOtherGravity();
        }
        tempScale.y = (yspeed < 0) ? Mathf.Abs(tempScale.y) : -Mathf.Abs(tempScale.y);
        transform.localScale = tempScale;
    }
    public void TakeDamage(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            //Destroy(gameObject);
            pos.x = xPosition;
            pos.y = yPosition;
            transform.position = pos;
        }
    }
    public void changeYourGravity()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            yspeed = -yspeed;
        }

    }



    public void changeOtherGravity() {
        if (Input.GetKeyDown(KeyCode.N))
        {
            GameObject.FindGameObjectWithTag("Player2").GetComponent<Player2>().yspeed *= -1;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            touchesEnemy = true;
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            touchesEnemy = false;
            isGrounded = false;
        }
    }

}
