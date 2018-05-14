using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour {

    public KeyCode[] MoveRight;
    public KeyCode[] MoveLeft;
    public KeyCode[] Jump;
    public KeyCode[] Interaction;
    public KeyCode[] Pause;
    public KeyCode[] Restart;

    public bool GetKeysDown(KeyCode[] keycodes)
    {
        foreach (KeyCode kc in keycodes)
        {
            if (GetKeyDown(kc))
            {
                return true;
            }
        }

        return false;
    }

    public bool GetKeyDown(KeyCode keycode)
    {
        if (Input.GetKeyDown(keycode))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
