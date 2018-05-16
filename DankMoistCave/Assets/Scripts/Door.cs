using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IState<bool> {

    [SerializeField]
    private bool m_IsDoorOpen;

    public Sprite m_OpenSprite;
    public Sprite m_CloseSprite;

    #region Interface Methods

    /// <summary>
    /// Changes door state if possible
    /// </summary>
    public void ChangeState()
    {
        if(CanStateChange())
        {
            m_IsDoorOpen = !m_IsDoorOpen;
        }        
    }

    public bool GetState()
    {
        return m_IsDoorOpen;
    }

    #endregion

    public bool CanStateChange()
    {
        return true;
    }

    public void Open()
    {
        // Play Animation
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = m_OpenSprite;
        m_IsDoorOpen = true;
    }

    public void Close()
    {
        // Play Animation
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = m_CloseSprite;
        m_IsDoorOpen = false;
    }

    void Start()
    {
        if (GetState())
        {
            Open();
        }
        else
        {
            Close();
        }
    }

}
