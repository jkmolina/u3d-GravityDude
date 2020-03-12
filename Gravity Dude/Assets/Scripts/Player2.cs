using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int hp = 100;
    public GameObject jugador2;
    public int xPosition;
    public int yPosition;
    public int xspeed;
    public int yspeed;
    public Rigidbody2D rb;
    bool isGrounded;
    bool touchesEnemy;
    Vector2 pos;  
    void Start()
    {
        Vector2 pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempScale = transform.localScale;
        tempScale.y = (yspeed < 0) ? Mathf.Abs(tempScale.y) : -Mathf.Abs(tempScale.y);
        transform.localScale = tempScale;
        GetComponent<Rigidbody2D>().velocity = new Vector2(xspeed, yspeed);

        if (isGrounded)
        {
            changeYourGravity();
        }

        if (touchesEnemy) 
        {
            changeOtherGravity();
        }
    }
    public void TakeDamage(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            pos.x = xPosition;
            pos.y = yPosition;
            transform.position = pos;
        }
    }

    public void changeYourGravity()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            yspeed = -yspeed;
        }
    }



    public void changeOtherGravity()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject.FindGameObjectWithTag("Player1").GetComponent<Player1>().yspeed *= -1;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Player1"))
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
        if (collision.gameObject.CompareTag("Player1"))
        {
            touchesEnemy = false;
            isGrounded = false;
        }
    }
}
