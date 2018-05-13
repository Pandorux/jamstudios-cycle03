using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class PressurePlate : Switch {

    public bool IsPressed()
    {
        return m_IsOn;
    }

    void OnTriggerEnter()
    {
        InvokeOff();
        m_IsOn = true;
    }

    void OnTriggerExit()
    {
        InvokeOn();
        m_IsOn = false;
    }

}
