using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class PressurePlate : Switch {

    public bool IsPressed()
    {
        return m_isActive;
    }

    void OnTriggerEnter()
    {
        InvokeOff();
        m_isActive = true;
    }

    void OnTriggerExit()
    {
        InvokeOn();
        m_isActive = false;
    }

}
