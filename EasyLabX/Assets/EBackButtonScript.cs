using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EBackButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BackButtonPressed();
    }

    /*
     * Loads the main experiment menu when back button is pressed.
     */
    void BackButtonPressed()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("ExperimentsMenu");
        }
    }
}
