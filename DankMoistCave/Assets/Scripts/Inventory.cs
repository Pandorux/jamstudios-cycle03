using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory {

    [Tooltip("The max amount of items the player can hold")]
    [SerializeField]
    private int m_Capacity = 50;

    [Tooltip("")]
    [SerializeField]
    private List<Item> m_Items;

    public void AddItem(Item item)
    {
        if (m_Items.Count < m_Capacity)
            m_Items.Add(item);
    }

    // TODO: What happens when the item is dropped
    public void RemoveItem(Item item)
    {
        foreach(Item i in m_Items)
        {
            if(i.GetName() == item.GetName())
            {
                m_Items.Remove(i);
                break;
            }
        }
    }

    // TODO:
    //public IHoldable GetItemByType<T>(IHoldable item)
    //{
    //    return null;
    //}

}
