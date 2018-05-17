using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHoldable {

    string GetName();
    bool CanBePickedUp();
    bool IsBeingHold();
    void PickUp(ref Inventory holder);
    void PutDown(ref Inventory holder);

}
