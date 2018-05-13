using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredLight : MonoBehaviour, ILight, IPowered<int>
{
    #region Variables

    protected const LightType type = LightType.Cold;

    [Tooltip("The light that'll emit illumination")]
    [SerializeField]
    protected Light light;

    [SerializeField]
    protected int intensity;

    [SerializeField]
    protected int warmth;

    [SerializeField]
    protected bool lightOn;

    [Tooltip("Amount of power being channeled into this device.")]
    [SerializeField]
    protected int voltage = 0;

    [SerializeField]
    protected int maxVoltage = 100;

    #endregion

    #region Interface Methods

    public int GetLightIntensity()
    {
        return intensity;
    }

    public LightType GetLightType()
    {
        return type;
    }

    public int GetWarmth()
    {
        return warmth;
    }

    public void SetLightIntensity(int str)
    {
        intensity = str;
    }

    public void SetWarmth(int w)
    {
        if (type == LightType.Warm || w == 0)
        {
            warmth = w;
        }
        else
        {
            throw new InvalidLightTypeException(
                "A cold light cannot have its warmth set to any number besides 0");
        }
    }

    public void ChangeState()
    {
        lightOn = !lightOn;
    }

    public void SetState(bool s)
    {
        lightOn = s;
    }

    public bool GetState()
    {
        return lightOn;
    }

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
        light.intensity = intensity;
        light.gameObject.SetActive(lightOn);
    }

}
