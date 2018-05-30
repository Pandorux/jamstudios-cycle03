using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.PostProcessing;

public class GameController : SingletonBase<GameController> {

    [Tooltip("The button that'll activate and deactivate the zippo")]
    public KeyCode k_ZippoButton = KeyCode.Q;

    [Tooltip("The button that'll be used to interact with world objects")]
    public KeyCode k_InteractionButton = KeyCode.E;

    [HideInInspector]
    public bool isGameRunning;

    private bool isGamePaused;

    public PlayerController player;

    public float dif;
    public PostProcessingProfile frozencorpse;
    

    public void PlayerInput()
    {
        if (Input.GetKeyDown(k_ZippoButton))
        {
            // Check if Player Can turn Zippo on or off
            // Turn Zippo on or off if possible
        }
        else if (Input.GetKeyDown(k_InteractionButton))
        {
            // Check if player can pickup an item
            // Pickup item if possible
        }
    }

    protected override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        PlayerInput();
        VignetteControl();
    }

    void Start()
    {
        
        dif = player.m_BodyTemperature.GetFreezingTemp() - player.m_BodyTemperature.GetFatalTemp();

    }

    public void ChangeTimeState(float newGameSpeed)
    {
        Time.timeScale = newGameSpeed;
    }

    public void ChangePauseState()
    {
        isGamePaused = !isGamePaused;

        if (isGamePaused == true)
        {
            UIController.instance.pauseMenu.SetActive(true);
            UIController.instance.hud.SetActive(false);
            ChangeTimeState(0.0f);
            Cursor.visible = true;
        }
        else
        {
            UIController.instance.pauseMenu.SetActive(false);
            UIController.instance.hud.SetActive(true);
            ChangeTimeState(1.0f);
            Cursor.visible = false;
        }
    }

	public void VignetteControl(){
        float curDif;
        curDif = player.m_BodyTemperature.GetCurrentTemp() - player.m_BodyTemperature.GetFatalTemp();
        curDif /= dif;
        curDif = curDif > 1 ? 0 : 1 - curDif;
        frozencorpse.vignette.settings.intensity = curDif;

    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void LoadSceneAsync(string name)
    {
        SceneManager.LoadSceneAsync(name);
    }

    public void LoadSceneAsync(int buildIndex)
    {
        SceneManager.LoadSceneAsync(buildIndex);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
