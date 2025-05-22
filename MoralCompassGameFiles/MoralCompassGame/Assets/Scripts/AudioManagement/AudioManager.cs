using UnityEngine;
using UnityEngine.Audio;
using System;

/*Reference:
Title: Introduction to AUDIO in Unity 
Author: Brackeys
Date: 2017a, May 31
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=6OT43pvUyfY
*/

public class AudioManager : MonoBehaviour
{
    public SoundScript[] sounds;

    public static AudioManager instance;

    //format for other scripts to use this audio:
    //the below will be used for any other script where audio shall be played
    //FindFirstObjectByType<AudioManager>().Play("DeathSound");  in the Play function, make sure syntax is correct

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (SoundScript s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("BackgroundMusic");
    }

    public void Play(string name)
    {
        SoundScript s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("There's a typo with " + name + " not found");
            return;
        }
        s.source.Play();
    }
}
