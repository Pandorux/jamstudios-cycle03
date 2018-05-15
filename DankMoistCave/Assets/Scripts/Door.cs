using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, /*IPowered<int>,*/ IState<bool> {

    [Tooltip("Amount of power being channeled into this device.")]
    [SerializeField]
    protected int m_voltage = 0;

    [SerializeField]
    protected int m_maxVoltage = 1;

    [SerializeField]
    private bool m_IsDoorOpen;

    #region Interface Methods

    //public void AddPower(int p)
    //{
    //    m_voltage += p;
    //    m_voltage = m_voltage > m_maxVoltage ? m_maxVoltage : m_voltage;
    //}

    //public int GetCurrentVoltage()
    //{
    //    return m_voltage;
    //}

    //public int GetMaxVoltage()
    //{
    //    return m_maxVoltage;
    //}

    //public void RemovePower(int p)
    //{
    //    m_voltage -= p;
    //    m_voltage = m_voltage <= 0 ? 0 : m_voltage;
    //}

    /// <summary>
    /// Changes door state if possiblw
    /// </summary>
    public void ChangeState()
    {
        if(CanStateChange())
        {
            m_IsDoorOpen = !m_IsDoorOpen;
        }        
    }

    public bool GetState()
    {
        return m_IsDoorOpen;
    }

    #endregion

    public bool CanStateChange()
    {
        //if(GetState())
        //{
        return true;
    //    }
    //    else
    //    {
    //        if(m_voltage == m_maxVoltage)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    }

    public void Open()
    {
        // Play Animation
        GetComponent<BoxCollider2D>().enabled = false;
        m_IsDoorOpen = true;
    }

    public void Close()
    {
        // Play Animation
        GetComponent<BoxCollider2D>().enabled = true;
        m_IsDoorOpen = false;
    }

    void Start()
    {
        if (GetState())
        {
            Open();
        }
        else
        {
            Close();
        }
    }

}
