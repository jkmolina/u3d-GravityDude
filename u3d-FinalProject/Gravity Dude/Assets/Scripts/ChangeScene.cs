//Universidad del Valle de Guatemala
//José Ovando 18071
//Joonho Kim 
//Pablo Ruiz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class    ChangeScene : MonoBehaviour
{

    public void selectScene()
    {

        switch (this.gameObject.name)
        {
            case "Button":
                SceneManager.LoadScene("SampleScene");
                break;

            case "Button1":
                SceneManager.LoadScene("SampleScene");
                break;

            case "Button2":
                SceneManager.LoadScene("MainMenu");
                break;



        }
    }

}
