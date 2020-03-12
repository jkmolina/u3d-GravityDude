//Universidad del Valle de Guatemala
//José Ovando 18071
//Joonho Kim 
//Pablo Ruiz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour
{


    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DesactivateMenu();

        }


    }

    void ActivateMenu()
    {
        Time.timeScale = 0;


        pauseMenuUI.SetActive(true);
    }

    public void DesactivateMenu()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenuUI.SetActive(false);
    }

    public void Regresar(string menu)
    {
        SceneManager.LoadScene("Game2");
    }


    public void Regresar2(string menu)
    {
        SceneManager.LoadScene("Game");
    }

}
