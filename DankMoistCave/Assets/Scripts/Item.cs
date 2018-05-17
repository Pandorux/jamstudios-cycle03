using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IHoldable {

    [Tooltip("Is this item being hold by something?")]
    [SerializeField]
    private string m_Name;

    [Tooltip("Is this item being hold by something?")]
    [SerializeField]
    private bool m_BeingHold = false;

    public bool CanBePickedUp()
    {
        return true;
    }

    public bool IsBeingHold()
    {
        return m_BeingHold;
    }

    // TODO:
    public void PickUp(ref Inventory holder)
    {
        //holder.AddItem(this);
        m_BeingHold = true;
    }

    // TODO:
    public void PutDown(ref Inventory holder)
    {
        //holder.RemoveItem();
        m_BeingHold = false;
    }

    public string GetName()
    {
        return m_Name;
    }

}
