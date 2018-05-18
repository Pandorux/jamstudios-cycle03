using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveableData {

    #region Data Persistence

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("musicVolume", 1);
    }

    /// <summary>
    ///  
    /// </summary>
    /// <param name="isCompleted"></param>
    public static void SetMusicVolume(float curVolume)
    {
        PlayerPrefs.SetFloat("musicVolume", curVolume);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float GetSoundVolume()
    {
        return PlayerPrefs.GetFloat("soundVolume", 1);
    }

    /// <summary>
    ///  
    /// </summary>
    /// <param name="isCompleted"></param>
    public static void SetSoundVolume(float curVolume)
    {
        PlayerPrefs.SetFloat("soundVolume", curVolume);
    }

    #endregion


}
