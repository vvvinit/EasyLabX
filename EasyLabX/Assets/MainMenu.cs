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

    int delayTime = 25;

    

    IEnumerator SetDelay(int time)
    {
        yield return new WaitForSeconds(time);
    }


    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void StartExperimentL1(GameObject g)
    {
        g.SetActive(true);
        StartCoroutine(SetDelay(delayTime));
        LoadScene("L1");
    }

    public void StartExperimentL2(GameObject g)
    {
        g.SetActive(true);
        StartCoroutine(SetDelay(delayTime));
        LoadScene("L2");
    }

    public void StartExperimentL3(GameObject g)
    {
        g.SetActive(true);
        StartCoroutine(SetDelay(delayTime));
        LoadScene("L3");
    }

    public void StartExperimentL4(GameObject g)
    {
        g.SetActive(true);
        StartCoroutine(SetDelay(delayTime));
        LoadScene("L4");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
