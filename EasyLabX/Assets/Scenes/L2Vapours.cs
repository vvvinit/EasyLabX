using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Vapours : MonoBehaviour
{
    float delayTime = 5;



    IEnumerator SetDelay(float time, GameObject g)
    {
        yield return new WaitForSeconds(time);
        g.SetActive(true);
        yield return new WaitForSeconds(2*time);
        g.SetActive(false);

    }


    public void startVapours(GameObject g)
    {
        StartCoroutine(SetDelay(delayTime, g));
    }
}
