//Universidad del Valle de Guatemala
//José Ovando 18071
//Joonho Kim 
//Pablo Ruiz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{

    public void selectScene()
    {

        switch (this.gameObject.name)
        {
            case "Button":
                SceneManager.LoadScene("SampleScene");
                break;

            case "Button1":
                SceneManager.LoadScene("Scene02");
                break;

            case "Button2":
                SceneManager.LoadScene("Scene03");
                break;

            case "Back":
                SceneManager.LoadScene("MainMenu");
                break;



        }
    }

}
