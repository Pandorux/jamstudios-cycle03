﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredLight : SwitchLight, IPowered<int>
{
    #region Variables

    [Tooltip("Amount of power being channeled into this device.")]
    [SerializeField]
    protected int voltage = 0;

    [SerializeField]
    protected int maxVoltage = 1;

    #endregion

    #region Interface Methods

    public void AddPower(int p)
    {
        voltage += p;
        voltage = voltage > maxVoltage ? maxVoltage : voltage;
    }

    public int GetCurrentVoltage()
    {
        return voltage;
    }

    public int GetMaxVoltage()
    {
        return maxVoltage;
    }

    public void RemovePower(int p)
    {
        voltage -= p;
        voltage = voltage < 0 ? 0 : voltage;
    }

    /// <summary>
    /// Switches the Light on and off if possible
    /// </summary>
    public virtual void ChangeState()
    {
        if(CanStateChange())
        {
            m_lightOn = !m_lightOn;
        }
    }

    new public bool CanStateChange()
    {
        if(GetState())
        {
            Debug.Log("Can Change");
            return true;
        }
        else
        {
            if(GetCurrentVoltage() == GetMaxVoltage())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    new public void TurnOn()
    {
        if(CanStateChange())
        {
            base.TurnOn();
        }
    }

    new public void TurnOff()
    {
        if (CanStateChange())
        {
            base.TurnOff();
        }
    }

    #endregion


    protected override void Start()
    {
        m_light.intensity = m_intensity;
        m_light.gameObject.SetActive(m_lightOn);

        if (GetState())
        {
            TurnOn();
            voltage = maxVoltage;
        }
        else
        {
            TurnOff();
            m_lightOn = false;
        }
    }
}
