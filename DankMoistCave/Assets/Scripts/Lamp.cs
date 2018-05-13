using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, ILight, IPowered<int>
{
    public void AddPower(int p)
    {
        throw new NotImplementedException();
    }

    public int GetCurrentVoltage()
    {
        throw new NotImplementedException();
    }

    public int GetLightIntensity()
    {
        throw new NotImplementedException();
    }

    public LightType GetLightType()
    {
        throw new NotImplementedException();
    }

    public int GetMaxVoltage()
    {
        throw new NotImplementedException();
    }

    public int GetWarmth()
    {
        throw new NotImplementedException();
    }

    public bool IsLightOn()
    {
        throw new NotImplementedException();
    }

    public void RemovePower(int p)
    {
        throw new NotImplementedException();
    }

    public void SetLightIntensity(int str)
    {
        throw new NotImplementedException();
    }

    public void SetLightType(LightType type)
    {
        throw new NotImplementedException();
    }

    public void SetWarmth(int w)
    {
        throw new NotImplementedException();
    }
}
