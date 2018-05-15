using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHoldable {

    bool CanBePickedUp();
    bool IsBeingHold();
    void PickUp(ref IHolder holder);
    void PutDown(ref IHolder holder);

}
