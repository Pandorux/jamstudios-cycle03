using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredLight : LightBase, IPowered<int>
{
    #region Variables

    [Tooltip("Amount of power being channeled into this device.")]
    [SerializeField]
    protected int voltage = 0;

    [SerializeField]
    protected int maxVoltage = 100;

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

    #endregion

    void Start()
    {
        base.Start();
    }
}
