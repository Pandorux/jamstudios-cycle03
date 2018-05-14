using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable {

    /// <summary>
    /// Is this object currently interactable
    /// </summary>
    /// <returns></returns>
    bool IsInteractable();
    void SetInteractability(bool b);
    void Interact();
    void TriggerOnStay(Collider c);

}
