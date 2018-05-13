using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour {

    [SerializeField]
    protected bool m_IsOn = false;

    [Tooltip("The methods that will be called when the pressure plate is stood on")]
    [SerializeField]
    protected UnityEvent m_On;

    [SerializeField]
    [Tooltip("The methods that will be called when the pressure plate is stepped off")]
    protected UnityEvent m_Off;

    // Use this for initialization
    void Start()
    {
        if (m_IsOn)
        {
            InvokeOn();
        }
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
