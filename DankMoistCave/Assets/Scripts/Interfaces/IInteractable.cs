using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable {

    /// <summary>
    /// Checks if object is close enough to interact
    /// </summary>
    bool InRange(GameObject obj);

    /// <summary>
    /// Is this object currently interactable
    /// </summary>
    /// <returns></returns>
    bool IsInteractable();

    void Interact();

}
