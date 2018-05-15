using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : SingletonBase<PlayerController>, IHolder
{
    #region Variables

    private bool m_isAlive = true;

    [Tooltip("Does the player have its Zippo Lighter out")]
    [SerializeField]
    private bool m_LightOn = true;

    [Tooltip("Does the player have their Zippo Lighter")]
    [SerializeField]
    private bool m_HasLight = true;

    [Tooltip("The body temperature of the player")]
    [SerializeField]
    [Range(-20, 65)] // TODO: Look up proper body temps
    private int m_BodyTemperature = 20;

    [Tooltip("Is player holding an item besides the Zippo Lighter?")]
    [SerializeField]
    private bool m_HasItem = false;

    [Tooltip("The Item the player is holding.")]
    [SerializeField]
    private IHoldable m_Item = null;

    private PlayerState m_state = PlayerState.Idle;

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

    public int GetBodyTemp()
    {
        return m_BodyTemperature;
    }

    public void ChangeState(PlayerState s)
    {
        m_state = s;
    }

    #endregion

    protected override void Awake()
    {
        base.Awake();
    }

}
