using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    
    void ChangeState();
    void SetState();
    void GetState();

}
