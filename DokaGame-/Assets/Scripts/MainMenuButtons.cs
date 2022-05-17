using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void starGame ()
    {
        SceneManager.LoadScene("Main");
    }
    
    public void quitGame ()
    {
        Debug.Log("The Game Has Shut Down Sucessfully!");
        Application.Quit();
    }

    // Update is called once per frame
    void Update() 
    {
        
    }
}
