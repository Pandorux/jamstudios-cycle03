using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlayerController : PlatformerCharacter2D
{
    #region Variables

    private bool m_isAlive = true;

    //[Tooltip("Does the player have its Zippo Lighter out")]
    //[SerializeField]
    //private bool m_LightOn = true;

    //[Tooltip("Does the player have their Zippo Lighter")]
    //[SerializeField]
    //private bool m_HasLight = true;


    [Tooltip("What is the normal movement speed of the player")]
    [SerializeField]
    [Range(0, 20)]
    private float m_MaxSpeed = 5;

    [Tooltip("What is the normal jump force of the player")]
    [SerializeField]
    [Range(0, 2000)]
    private float m_MaxJumpForce = 400;

    [SerializeField]
    private BodyTemperature m_BodyTemperature;

    [SerializeField]
    private Inventory m_inventory;

    #endregion

    #region Class Methods

    public bool IsAlive()
    {
        return m_isAlive;
    }

    //public bool HasZippo()
    //{
    //    return m_HasLight;
    //}

    //public void LoseZippo()
    //{
    //    m_HasLight = false;
    //}

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

}
