using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class PressurePlate : MonoBehaviour
{

    [SerializeField]
    private bool m_isActive = false;
    [Tooltip("The methods that will be called when the pressure plate is stood on")]
    public UnityEvent m_On;
    [Tooltip("The methods that will be called when the pressure plate is stepped off")]
    public UnityEvent m_Off;

    // Use this for initialization
    void Start()
    {
        if (m_isActive)
        {
            InvokeOn();
        }
    }
    
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

    public void InvokeOn()
    {
        m_On.Invoke();
    }

    public void InvokeOff()
    {
        m_Off.Invoke();
    }
}
