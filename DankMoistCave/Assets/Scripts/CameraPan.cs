using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

    // variable for the main camera attached to the player

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //change y position to be -4 units from its original position when in the trigger. Upon exiting the view should go back to normal.
    }
}
