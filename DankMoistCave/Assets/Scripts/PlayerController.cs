using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

[RequireComponent(typeof(Platformer2DUserControl))]
public class PlayerController : MonoBehaviour {
    #region Variables

    private bool m_isAlive = true;

    //[Tooltip("Does the player have its Zippo Lighter out")]
    //[SerializeField]
    //private bool m_LightOn = true;

    //[Tooltip("Does the player have their Zippo Lighter")]
    //[SerializeField]
    //private bool m_HasLight = true;

    [SerializeField]
    private BodyTemperature m_BodyTemperature;

    [SerializeField]
    private Inventory m_inventory;

    #endregion

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

    public void SlowMovement()
    {
        PlatformerCharacter2D pc = GetComponent<PlatformerCharacter2D>();

        // TODO: Make more readable
        if (m_BodyTemperature.GetCurrentTemp() < m_BodyTemperature.GetFreezingTemp())
        {
            float diff = m_BodyTemperature.GetFreezingTemp() - m_BodyTemperature.GetFatalTemp(); // Norm Diff
            float curDiff = m_BodyTemperature.GetFreezingTemp() - m_BodyTemperature.GetCurrentTemp(); // Cur Diff
            float percentile = (curDiff / diff);
            float lost = m_BodyTemperature.GetMaxSpeedLost() * percentile;

            pc.m_Speed = pc.m_MaxSpeed * (1 - lost);
            pc.m_JumpForce = pc.m_MaxJumpForce * (1 - lost);
        }
    }

    public void Death()
    {
        m_isAlive = false;
        Destroy(gameObject);
    }

    void Update()
    {
        SlowMovement();

        if (m_BodyTemperature.GetCurrentTemp() < m_BodyTemperature.GetFatalTemp()) 
        {
            Death();
        }
    }

}
