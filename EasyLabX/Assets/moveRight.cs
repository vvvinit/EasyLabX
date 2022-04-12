using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    bool ispressed = false; 
    public GameObject player; 

    void Update()
    {
        if(ispressed)
        {
            player.transform.Translate(0.2f, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData) 
    {
        ispressed = true;
    }
    
    public void OnPointerUp(PointerEventData eventData) 
    {
        ispressed = false;
    }
}
