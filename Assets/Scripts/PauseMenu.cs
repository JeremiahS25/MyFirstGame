using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1.0f;

            //when ispaused is true, this line will set it to false
            pauseUI.SetActive(true);

            //When ispausedis true, this line will set it to false
            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0.0f;

            //Shows thebutton when the game is paused  
            pauseUI.SetActive(true);

            isPaused = true;
        }

        //isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
