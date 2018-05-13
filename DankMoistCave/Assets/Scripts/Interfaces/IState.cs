using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState<T> {
    
    void ChangeState();
    void SetState(T s);
    T GetState();

}
