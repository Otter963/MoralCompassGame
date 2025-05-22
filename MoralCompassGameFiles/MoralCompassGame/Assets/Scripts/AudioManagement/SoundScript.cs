using UnityEngine;
using UnityEngine.Audio;

/*Reference:
Title: Introduction to AUDIO in Unity 
Author: Brackeys
Date: 2017a, May 31
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=6OT43pvUyfY
*/

[System.Serializable]
public class SoundScript
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
