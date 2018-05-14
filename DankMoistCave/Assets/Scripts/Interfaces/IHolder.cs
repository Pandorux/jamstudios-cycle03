using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHolder {

    bool IsHoldingItem(IHoldable item);
    void AddItem(IHoldable item);
    void RemoveItem();
    IHoldable GetItem();

}
