using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlayerController : PlatformerCharacter2D, IHolder
{
    #region Subclasses

    [System.Serializable]
    private class BodyTemperature
    {
        [Tooltip("The body temperature of the player")]
        [SerializeField]
        [Range(0, 100)] // TODO: Look up proper body temps
        private float m_BodyTemperature = 50;

        [Tooltip("The player's max body temperature")]
        [SerializeField]
        private float m_MaxTemperature = 100;

        [Tooltip("How quickly the player will lose body heat")]
        public float m_HeatLostRate = 1;

        [Tooltip("Player movement will slow under this temperature")]
        [SerializeField]
        [Range(0, 100)]
        private float m_SlowThreshold = 50;

        public float GetBodyTemp()
        {
            return m_BodyTemperature;
        }

        public void RaiseBodyTemp(int degrees = 1)
        {
            m_BodyTemperature += degrees;
        }

        public void LowerBodyTemp()
        {
            m_BodyTemperature -= m_HeatLostRate;
        }
    }

    #endregion

    #region Variables

    private bool m_isAlive = true;

    [Tooltip("Does the player have its Zippo Lighter out")]
    [SerializeField]
    private bool m_LightOn = true;

    [Tooltip("Does the player have their Zippo Lighter")]
    [SerializeField]
    private bool m_HasLight = true;

    [Tooltip("What is the normal movement speed of the player")]
    [SerializeField]
    [Range(0, 20)]
    private float m_MaxSpeed = 5;

    [Tooltip("What is the normal jump force of the player")]
    [SerializeField]
    [Range(0, 2000)]
    private float m_MaxJumpForce = 400;

    [Tooltip("Is player holding an item besides the Zippo Lighter?")]
    [SerializeField]
    private bool m_HasItem = false;

    [Tooltip("The Item the player is holding.")]
    [SerializeField]
    private IHoldable m_Item = null;

    [SerializeField]
    private BodyTemperature m_BodyTemperature;

    // TODO: Figure if needed
    // private PlayerState m_state = PlayerState.Idle;

    #endregion

    #region Interface Methods

    public bool IsHoldingItem()
    {
        return m_HasItem;
    }

    public void AddItem(IHoldable item)
    {
        if (m_Item != null)
            m_Item = item;
    }

    public IHoldable GetItem()
    {
        return m_Item;
    }

    // TODO: What happens when the item is dropped
    public void RemoveItem()
    {
        m_Item = null;
    }

    // Not Sure if this will work
    public bool IsHoldingItem(IHoldable item)
    {
        if (GetItem() == item)
            return true;
        else
            return false;
    }

    #endregion

    #region Class Methods

    public bool IsAlive()
    {
        return m_isAlive;
    }

    public bool HasZippo()
    {
        return m_HasLight;
    }

    public void LoseZippo()
    {
        m_HasLight = false;
    }

    //public void ChangeState(PlayerState s)
    //{
    //    m_state = s;
    //}

    //public void SlowMovement()
    //{
    //    // TODO: Add Dynamic Theshold
    //    if(GetBodyTemp() < m_MaxTemperature / m_SlowThreshold)
    //    {
    //        m_Speed = m_MaxSpeed * (GetBodyTemp() / (m_MaxTemperature / m_SlowThreshold));
    //        m_JumpForce = m_MaxJumpForce * (GetBodyTemp() / (m_MaxJumpForce / m_SlowThreshold));
    //    }
    //}

    #endregion

    protected void FixUpdate()
    {
        //if(!m_LightOn)
        //{
        //    LowerBodyTemp();
        //}
    }

}
