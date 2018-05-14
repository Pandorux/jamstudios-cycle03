﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : SingletonBase<GameController> {

    [Tooltip("The button that'll activate and deactivate the zippo")]
    public const KeyCode k_ZippoButton = KeyCode.Q;

    [Tooltip("The button that'll be used to interact with world objects")]
    public const KeyCode k_InteractionButton = KeyCode.E;

    protected override void Awake()
    {
        base.Awake();
    }

    public void PlayerInput()
    {
        if(Input.GetKeyDown(k_ZippoButton))
        {
            // Check if Player Can turn Zippo on or off
            // Turn Zippo on or off if possible
        }
        else if(Input.GetKeyDown(k_InteractionButton))
        {
            // Check if player can pickup an item
            // Pickup item if possible
        }
    }

}
