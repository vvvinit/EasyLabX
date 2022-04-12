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

    int delayTime = 7;

    

    IEnumerator SetDelay(int time, GameObject g, string s)
    {
        g.SetActive(true);
        yield return new WaitForSeconds(time);
        LoadScene(s);
    }


    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void StartExperimentL1(GameObject g)
    {
        StartCoroutine(SetDelay(delayTime, g, "L1"));
    }

    public void StartExperimentL2(GameObject g)
    {
        StartCoroutine(SetDelay(delayTime, g, "L2"));
    }

    public void StartExperimentL3(GameObject g)
    {
        StartCoroutine(SetDelay(delayTime, g, "L3"));

    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
