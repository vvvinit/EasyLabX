using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pHPaperChange : MonoBehaviour
{
    float delayTime = 6;



    IEnumerator SetDelay(float time, GameObject g)
    {
        yield return new WaitForSeconds(time);
        g.SetActive(true);
    }


    public void changepHPaper(GameObject g)
    {
        StartCoroutine(SetDelay(delayTime, g));  
    }

}
