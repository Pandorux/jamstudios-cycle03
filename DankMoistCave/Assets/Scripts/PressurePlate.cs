using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour, IState {

    [SerializeField]
    private bool m_isActive = false;
    [Tooltip("The methods that will be called when the pressure plate is stood on")]
    public UnityEvent m_On;
    [Tooltip("The methods that will be called when the pressure plate is stepped off")]
    public UnityEvent m_Off;

    // Use this for initialization
    void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeState()
    {
        throw new NotImplementedException();
    }

    public void SetState()
    {
        throw new NotImplementedException();
    }

    public void GetState()
    {
        throw new NotImplementedException();
    }
}
