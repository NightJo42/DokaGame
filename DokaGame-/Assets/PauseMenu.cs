using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }
    void Paused ()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main-Menu");
    }

    public void QuitGameMenu()
    {
        Application.Quit();
    }
}
