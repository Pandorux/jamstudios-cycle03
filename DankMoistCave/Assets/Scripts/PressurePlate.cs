using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class PressurePlate : Switch {

    public Sprite m_DownSprite;
    public Sprite m_UpSprite;

    public bool IsPressed()
    {
        return m_IsOn;
    }

    public void Switch()
    {
        if(m_IsOn)
        {
            InvokeOff();
            m_IsOn = false;
        }
        else
        {
            InvokeOn();
            m_IsOn = true;
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        
        GetComponent<SpriteRenderer>().sprite = m_DownSprite;
        Switch();
    }

    void OnTriggerExit2D(Collider2D c)
    {
        GetComponent<SpriteRenderer>().sprite = m_UpSprite;
        Switch();
    }

}
