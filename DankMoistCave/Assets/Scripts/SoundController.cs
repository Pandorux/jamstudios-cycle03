using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : SingletonBase<SoundController> {

    public AudioSource backgroundSource;
    public AudioSource[] sounds;

    protected override void Awake()
    {
        base.Awake();

        backgroundSource.volume = SaveableData.GetMusicVolume();

        foreach (AudioSource sound in sounds)
        {
            sound.volume = SaveableData.GetSoundVolume();
        }
    }

    public void CreateNewSound(AudioClip sound, bool loopSound = false)
    {
        GameObject obj = new GameObject();
        obj.transform.parent = transform;
        obj.AddComponent<AudioSource>();
        obj.GetComponent<AudioSource>().clip = sound;
        obj.GetComponent<AudioSource>().loop = loopSound;
        obj.GetComponent<AudioSource>().volume *= SaveableData.GetSoundVolume();
        obj.GetComponent<AudioSource>().Play();

        if (!loopSound)
            Destroy(obj, sound.length);
    }

    public float ReturnSoundVolume()
    {
        return SaveableData.GetSoundVolume();
    }
}
