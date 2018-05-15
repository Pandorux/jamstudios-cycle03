using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredDoor : Door, IPowered<int> {

    [Tooltip("Amount of power being channeled into this device.")]
    [SerializeField]
    protected int m_voltage = 0;

    [SerializeField]
    protected int m_maxVoltage = 1;

    #region Interface Methods

    public void AddPower(int p)
    {
        m_voltage += p;
        m_voltage = m_voltage > m_maxVoltage ? m_maxVoltage : m_voltage;
    }

    public int GetCurrentVoltage()
    {
        return m_voltage;
    }

    public int GetMaxVoltage()
    {
        return m_maxVoltage;
    }

    public void RemovePower(int p)
    {
        m_voltage -= p;
        m_voltage = m_voltage <= 0 ? 0 : m_voltage;
    }

    #endregion

    new public bool CanStateChange()
    {
        if (GetState())
        {
            return true;
        }
        else
        {
            if (m_voltage == m_maxVoltage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
