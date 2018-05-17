using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Item))]
public class Candle : SwitchLight, IInteractable, IDeath
{
    #region Variables

    [Tooltip("How long a candle will burn for")]
    [Range(0, 120)]
    [SerializeField]
    private float m_burnDuration = 10;

    [Tooltip("How long until candle fully fades from view")]
    [Range(0, 15)]
    [SerializeField]
    private float m_FadeDuration = 3;

    private float m_burnTimeLeft;
    private bool m_IsAlive = true;

    #endregion

    #region Interface Methods

    public void Interact()
    {
        ChangeState();
    }

    // TODO: doesn't return correct value
    public bool IsInteractable()
    {
        return gameObject.active;
    }

    public void SetInteractability(bool b)
    {
        foreach(Collider c in GetComponents<Collider>())
        {
            c.enabled = b;
        } 
    }

    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    public bool IsAlive()
    {
        return m_IsAlive;
    }

    public void SetAlive(bool a)
    {
        m_IsAlive = a;
    }

    // TODO: Need to Refine this
    public void Fade(float dur)
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        Color32 col = s.color;

        int speed = (int)(col.a / dur);
        col = new Color32(col.r, col.b, col.g, (byte)(col.a - speed));
        s.color = col;

        if(col.a > 0)
        {
            Fade(dur);
        }
        else
        {
            DestroyThis();
        }
    }

    #endregion

    /// <summary>
    /// Get the amount of time left that the candle can burn
    /// </summary>
    /// <returns></returns>
    public float GetTimeLeft()
    {
        return m_burnTimeLeft;
    }

    public float GetLifeTime()
    {
        return m_burnDuration;
    }

    /// <summary>
    /// Reduces Time Left for Candle unless Time Left leff than or equal to 0
    /// </summary>
    protected void BurnTick()
    {
        if (GetTimeLeft() <= 0)
        {
            m_burnTimeLeft--;
        }
    }

    protected override void Start()
    {
        base.Start();
    }

    protected virtual void Update()
    {
        if(GetTimeLeft() <= 0 && IsAlive())
        {
            SetAlive(false);
            ChangeState();
            SetInteractability(false);
            Fade(m_FadeDuration);
        }
    }

    protected virtual void FixUpdate()
    {
        if(GetState())
        {
            BurnTick();
        }
    }

    // TODO: Trigger should check for key input
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
