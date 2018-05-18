using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : SingletonBase<UIController> {

    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public GameObject hud;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
    }

    public void GameOverScreen()
    {
        gameOverMenu.SetActive(true);
    }
}
