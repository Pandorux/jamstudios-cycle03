using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class PressurePlate : Switch {

    public Sprite m_DownSprite;
    public Sprite m_UpSprite;
    private int peepsOnPP = 0;

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
        if(!c.isTrigger)
        {
            InvokeOn();
            GetComponent<SpriteRenderer>().sprite = m_DownSprite;
            m_IsOn = true;
            peepsOnPP++;
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        if(!c.isTrigger)
        {
            peepsOnPP--;
            if (peepsOnPP == 0)
            {
                InvokeOff();
                m_IsOn = false;
                GetComponent<SpriteRenderer>().sprite = m_UpSprite;
            }

        }
    }

}
