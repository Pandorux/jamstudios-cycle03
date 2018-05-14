using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LightBase : MonoBehaviour, ILight {

    #region Variables

    protected const LightType m_type = LightType.Cold;

    [Tooltip("The light that'll emit illumination")]
    [SerializeField]
    protected Light m_light;

    [SerializeField]
    protected int m_intensity;

    [Tooltip("The amount of heat the light emits")]
    [SerializeField]
    protected int m_warmth;

    [SerializeField]
    protected bool m_lightOn;

    #endregion

    #region Interface Methods

    public int GetLightIntensity()
    {
        return m_intensity;
    }

    public LightType GetLightType()
    {
        return m_type;
    }

    public virtual int GetWarmth()
    {
        return m_warmth;
    }

    public virtual void SetLightIntensity(int str)
    {
        m_intensity = str;
    }

    public virtual void SetWarmth(int w)
    {
        m_warmth = w;
    }

    /// <summary>
    /// Switches the Light on and off
    /// </summary>
    public virtual void ChangeState()
    {
        m_lightOn = !m_lightOn;
    }

    public virtual bool GetState()
    {
        return m_lightOn;
    }

    #endregion

    protected virtual void Start()
    {
        m_light.intensity = m_intensity;
        m_light.gameObject.SetActive(m_lightOn);
    }

    // TODO:
    public bool CanStateChange()
    {
        throw new NotImplementedException();
    }
}
