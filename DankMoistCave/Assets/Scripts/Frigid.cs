using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frigid : MonoBehaviour, IState<EnemyState> {

    [SerializeField]
    private EnemyState m_state;

    public void ChangeState()
    {
        throw new NotImplementedException();
    }

    public EnemyState GetState()
    {
        throw new NotImplementedException();
    }

    public void SetState(EnemyState s)
    {
        throw new NotImplementedException();
    }

}
