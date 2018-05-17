using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class SwitchLight : MonoBehaviour, ILight {

    #region Variables

    [Tooltip("The type of light being used")]
    [SerializeField]
    protected LightType m_type = LightType.Cold;

    [Tooltip("The light that'll emit illumination")]
    [SerializeField]
    protected Light m_light;

    [SerializeField]
    protected float m_intensity;

    [Tooltip("The amount of heat the light emits")]
    [SerializeField]
    protected float m_warmth;

    [SerializeField]
    protected bool m_lightOn;

    #endregion

    #region Interface Methods

    public float GetLightIntensity()
    {
        return m_intensity;
    }

    public LightType GetLightType()
    {
        return m_type;
    }

    public virtual float GetWarmth()
    {
        return m_warmth;
    }

    public virtual void SetLightIntensity(float str)
    {
        m_intensity = str;
    }

    public virtual void SetWarmth(float w)
    {
        m_warmth = w;
    }

    /// <summary>
    /// Switches the Light on and off
    /// </summary>
    public virtual void ChangeState()
    {
        if (m_lightOn)
            TurnOff();
        else
            TurnOn();
    }

    public virtual bool GetState()
    {
        return m_lightOn;
    }

    public void TurnOn()
    {
        m_light.gameObject.SetActive(true);
        m_lightOn = true;
    }

    public void TurnOff()
    {
        m_light.gameObject.SetActive(false);
        m_lightOn = false;
    }

    public bool CanStateChange()
    {
        return true;
    }

    #endregion

    protected virtual void Start()
    {
        m_light.intensity = m_intensity;
        m_light.gameObject.SetActive(m_lightOn);

        if (GetState())
        {
            TurnOn();
        }
        else
        {
            TurnOff();
        }
    }

    void OnTriggerStay2D(Collider2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            if(GetLightType() == LightType.Warm)
            {
                c.gameObject
                    .GetComponent<PlayerController>()
                    .m_BodyTemperature
                    .RaiseTemp(m_warmth);
            }
        }
    }
}
