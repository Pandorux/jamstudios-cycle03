using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IPowered<int>
{
    public void AddPower(int p)
    {
        throw new NotImplementedException();
    }

    public int GetCurrentVoltage()
    {
        throw new NotImplementedException();
    }

    public int GetMaxVoltage()
    {
        throw new NotImplementedException();
    }

    public void RemovePower(int p)
    {
        throw new NotImplementedException();
    }
}
