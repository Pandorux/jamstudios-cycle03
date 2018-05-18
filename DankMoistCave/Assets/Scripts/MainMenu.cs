using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu {

    public Slider soundVol;
    public Slider musicVol;

    void Start()
    {
        soundVol.value = SaveableData.GetSoundVolume();
        musicVol.value = SaveableData.GetMusicVolume();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void SaveSoundVolume()
    {
        SaveableData.SetSoundVolume(soundVol.value);
    }

    public void SaveMusicVolume()
    {
        SaveableData.SetMusicVolume(musicVol.value);
    }

}
