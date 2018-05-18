using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class SwitchLight : MonoBehaviour, ILight {

    #region Variables

    [Tooltip("The type of light being used")]
    [SerializeField]
    protected LightType m_Type = LightType.Cold;

    [Tooltip("The light that'll emit illumination")]
    [SerializeField]
    protected Light m_Light;

    [SerializeField]
    protected float m_Intensity;

    [Tooltip("The amount of heat the light emits")]
    [SerializeField]
    protected float m_Warmth;

    [SerializeField]
    protected bool m_LightOn;

    #endregion

    #region Interface Methods

    public float GetLightIntensity()
    {
        return m_Intensity;
    }

    public LightType GetLightType()
    {
        return m_Type;
    }

    public virtual float GetWarmth()
    {
        return m_Warmth;
    }

    public virtual void SetLightIntensity(float str)
    {
        m_Intensity = str;
    }

    public virtual void SetWarmth(float w)
    {
        m_Warmth = w;
    }

    /// <summary>
    /// Switches the Light on and off
    /// </summary>
    public virtual void ChangeState()
    {
        if (m_LightOn)
            TurnOff();
        else
            TurnOn();
    }

    public virtual bool GetState()
    {
        return m_LightOn;
    }

    public void TurnOn()
    {
        m_Light.gameObject.SetActive(true);
        m_LightOn = true;
    }

    public void TurnOff()
    {
        m_Light.gameObject.SetActive(false);
        m_LightOn = false;
    }

    public bool CanStateChange()
    {
        return true;
    }

    #endregion

    protected virtual void Start()
    {
        m_Light.intensity = m_Intensity;
        m_Light.gameObject.SetActive(m_LightOn);

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
                    .RaiseTemp(m_Warmth * Time.deltaTime);
            }
        }
    }
}
