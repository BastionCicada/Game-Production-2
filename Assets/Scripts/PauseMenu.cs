using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
public static bool GameIsPaused = false;
public GameObject pauseMenu;


    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)) // checks if esc has been pressed
      {
        if (GameIsPaused) // checks if the bool is set to true or false
        {
            Resume(); // if false, resume
        }
        else
        {
            Pause(); // if true, pause
        }
      }  
    }


    public void Resume()
    {
        pauseMenu.SetActive(false); // sets the pausemenu to active
        Time.timeScale = 1f; // resumes time
        GameIsPaused = false; // changes the checking bool to false
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor to the screen

        
    }
    
    public void Pause()
    {
        pauseMenu.SetActive(true); // sets the pause menu to true
        Time.timeScale = 0f; // pauses time
        GameIsPaused = true; // sets the checking bool to true
        Cursor.lockState = CursorLockMode.None; // unlocks the cursor
    }

    public void Quit()
    {
        SceneManager.LoadScene(0); // loads the menu
        Time.timeScale = 1f; // resumes time
    }

}
