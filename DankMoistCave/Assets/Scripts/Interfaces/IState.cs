using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState<T> {
    
    void ChangeState();
    bool CanStateChange();
    T GetState();

}
