using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            Debug.Log("Killed Player 1!");
            Destroy(collision.gameObject);
            //load scene
        }
        if (collision.CompareTag("Player2"))
        {
            Debug.Log("Killed PLayer 2!");
            Destroy(collision.gameObject);
            //load scene
        }
    }
}
