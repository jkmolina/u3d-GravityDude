using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObject : MonoBehaviour
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
            Debug.Log("Player 1 Wins!");
            Destroy(collision.gameObject);
            //load scene
        }
        if (collision.CompareTag("Player2"))
        {
            Debug.Log("Player 2 Wins!");
            Destroy(collision.gameObject);
            //load scene
        }
    }
}
