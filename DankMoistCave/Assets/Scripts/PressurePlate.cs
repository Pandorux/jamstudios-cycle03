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

    void OnTriggerEnter2D(Collider2D c)
    {
        InvokeOn();
        GetComponent<SpriteRenderer>().sprite = m_DownSprite;
        m_IsOn = true;
    }

    void OnTriggerExit2D(Collider2D c)
    {
        InvokeOff();
        GetComponent<SpriteRenderer>().sprite = m_UpSprite;
        m_IsOn = false;
    }

}
