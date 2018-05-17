using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class BodyTemperature : ITemperate<float>
{
    [Tooltip("The normal body temperature")]
    [SerializeField]
    private float m_NormalTemperature = 37;

    [Tooltip("The current body temperature")]
    [SerializeField]
    private float m_CurrentTemperature = 37;

    [Tooltip("The max body temperature")]
    [SerializeField]
    private float m_MaxTemperature = 40;

    [Tooltip("How quickly body heat will be lost")]
    public float m_HeatLostRate = 1;

    [Tooltip("Movement will slow under this temperature")]
    [SerializeField]
    private float m_FreezingTemperature = 35;

    [Tooltip("Death will be induced at this temperature")]
    [SerializeField]
    private float m_FatalLowTemperature = 28;

    [Tooltip("The slowest speed you'll move when you're freezing cold")]
    [SerializeField]
    [Range(0, 1)]
    private float m_MaxSpeedLost = 0.7f;

    #region Interface Methods

    public float GetCurrentTemp()
    {
        return m_CurrentTemperature;
    }

    public void RaiseTemp(float degrees = 1)
    {
        m_CurrentTemperature += degrees;
    }

    public void LowerTemp(float degrees = 1)
    {
        m_CurrentTemperature -= degrees;
    }

    public float GetNormalTemp()
    {
        return m_NormalTemperature;
    }

    #endregion

    public float GetFreezingTemp()
    {
        return m_FreezingTemperature;
    }

    public float GetFatalTemp()
    {
        return m_FatalLowTemperature;
    }

    public float GetMaxSpeedLost()
    {
        return m_MaxSpeedLost;
    }

}
