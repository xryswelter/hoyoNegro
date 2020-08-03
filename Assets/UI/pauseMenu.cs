using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Got my code for this part from Brackeys on Youtube "PAUSE MENU in Unity"

public class pauseMenu : MonoBehaviour
{
    //Sets game is running
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject bkg;

    // Update is called once per frame
    private void Update()
    {
        //Esc button listener
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(Time.timeScale);
            if (!gameIsPaused)
            {
                Pause();
            }
        }
    }

    //Resume Game Function
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        bkg.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    //Pause Game Function
    private void Pause()
    {
        Cursor.lockState = CursorLockMode.Confined;
        pauseMenuUI.SetActive(true);
        bkg.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadJournal()
    {
        Debug.Log("Loading Journal");
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
