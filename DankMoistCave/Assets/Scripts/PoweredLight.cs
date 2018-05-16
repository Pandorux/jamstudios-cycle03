using System.Collections;
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

    public virtual bool GetState()
    {
        return m_lightOn;
    }

    public bool CanStateChange()
    {
        if(GetState())
        {
            return true;
        }
        else
        {
            if(voltage == maxVoltage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    #endregion

    public void TurnOn()
    {
        if(CanStateChange())
        {
            m_light.gameObject.SetActive(true);
            ChangeState();
        }
    }

    public void TurnOff()
    {
        if (CanStateChange())
        {
            m_light.gameObject.SetActive(false);
            ChangeState();
        }
    }

    protected override void Start()
    {
        base.Start();

        if(GetState())
        {
            TurnOn();
        }
        else
        {
            TurnOff();
        }
    }
}
