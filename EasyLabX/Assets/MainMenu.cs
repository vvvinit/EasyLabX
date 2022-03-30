using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
     * Function that loads up the E1 Scene.
     * Make sure you add the E1 scene in the build settings.
     * The build index offset should be set accordingly.
     */
    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
