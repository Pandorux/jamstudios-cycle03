using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDeath {

    /// <summary>
    /// When object is killed it'll slowly fade from screen
    /// </summary>
    void Fade(float dur);
    void DestroyThis();
    bool IsAlive();
    void SetAlive(bool a);

}
