using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitch : Switch, IInteractable
{
    public Sprite m_OnSprite;
    public Sprite m_OffSprite;

    [SerializeField]
    private float m_InteractionDistance;

    #region Interface Method

    public void Interact()
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();

        if (m_IsOn)
        {
            m_IsOn = false;
            Debug.Log("Off");
            s.sprite = m_OnSprite;
            InvokeOff();
        }
        else
        {
            m_IsOn = true;
            Debug.Log("On");
            s.sprite = m_OffSprite;
            InvokeOn();
        }
    }

    public bool IsInteractable()
    {
        return gameObject.active;
    }

    // TODO:
    public void SetInteractability(bool b)
    {
        throw new NotImplementedException();
    }

    #endregion

    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
        }
    }

}
