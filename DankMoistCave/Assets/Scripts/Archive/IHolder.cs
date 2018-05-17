using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete("Interface deprecated, use Inventory instead")]
public interface IHolder {

    bool IsHoldingItem(IHoldable item);
    void AddItem(IHoldable item);
    void RemoveItem(IHoldable item);
    IHoldable GetItem();

}
