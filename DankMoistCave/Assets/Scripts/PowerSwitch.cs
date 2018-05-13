using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitch : Switch, IInteractable
{
    [SerializeField]
    private float m_InteractionDistance;

    #region Interface Method

    public void Interact()
    {
        if(m_IsOn)
        {
            m_IsOn = false;
            InvokeOn();
        }
        else
        {
            m_IsOn = true;
            InvokeOff();
        }
    }

    public bool IsInteractable()
    {
        return gameObject.active;
    }

    public void SetInteractability(bool b)
    {
        throw new NotImplementedException();
    }

    #endregion

    void IInteractable.TriggerOnStay(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {
            // TODO: Check for Button Press
            // Interact();
        }
    }

}
