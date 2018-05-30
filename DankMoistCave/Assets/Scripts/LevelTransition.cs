using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour {

    public int levelIndex;

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            GameController.instance.LoadScene(levelIndex);
        }
    }
}
