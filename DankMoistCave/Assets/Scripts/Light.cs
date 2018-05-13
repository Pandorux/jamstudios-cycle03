using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LightBase : MonoBehaviour, ILight {

    #region Variables

    protected const LightType type = LightType.Cold;

    [Tooltip("The light that'll emit illumination")]
    [SerializeField]
    protected Light light;

    [SerializeField]
    protected int intensity;

    [Tooltip("The amount of heat the light emits")]
    [SerializeField]
    protected int warmth;

    [SerializeField]
    protected bool lightOn;

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

    public virtual int GetWarmth()
    {
        return warmth;
    }

    public virtual void SetLightIntensity(int str)
    {
        intensity = str;
    }

    public virtual void SetWarmth(int w)
    {
        warmth = w;
    }

    public virtual void ChangeState()
    {
        lightOn = !lightOn;
    }

    public virtual void SetState(bool s)
    {
        lightOn = s;
    }

    public virtual bool GetState()
    {
        return lightOn;
    }

#endregion

    protected virtual void Start()
    {
        light.intensity = intensity;
        light.gameObject.SetActive(lightOn);
    }
}
