using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
private class BodyTemperature : MonoBehaviour, ITemperate<float>
{
    [Tooltip("The normal body temperature of the player")]
    [SerializeField]
    private float m_NormalTemperature = 37;

    [Tooltip("The body temperature of the player")]
    [SerializeField]
    private float m_CurrentTemperature = 37;

    [Tooltip("The player's max body temperature")]
    [SerializeField]
    private float m_MaxTemperature = 40;

    [Tooltip("How quickly the player will lose body heat")]
    public float m_HeatLostRate = 1;

    [Tooltip("Player movement will slow under this temperature")]
    [SerializeField]
    private float m_FreezingTemperature = 35;

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

}
