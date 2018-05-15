using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IState<bool> {

    [SerializeField]
    private bool m_IsDoorOpen;

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
        m_IsDoorOpen = true;
    }

    public void Close()
    {
        // Play Animation
        GetComponent<BoxCollider2D>().enabled = true;
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
