using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, ILight, IDeath
{
    public bool CanStateChange()
    {
        throw new NotImplementedException();
    }

    public void ChangeState()
    {
        throw new NotImplementedException();
    }

    public void DestroyThis()
    {
        throw new NotImplementedException();
    }

    public void Fade(float dur)
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

    public bool GetState()
    {
        throw new NotImplementedException();
    }

    public int GetWarmth()
    {
        throw new NotImplementedException();
    }

    public bool IsAlive()
    {
        throw new NotImplementedException();
    }

    public void SetAlive(bool a)
    {
        throw new NotImplementedException();
    }

    public void SetLightIntensity(int str)
    {
        throw new NotImplementedException();
    }

    public void SetWarmth(int w)
    {
        throw new NotImplementedException();
    }
}
