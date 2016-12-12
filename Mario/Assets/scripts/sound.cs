using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class sound : MonoBehaviour
{

    //sound variables
    public AudioSource SFX;
    public static sound Instance;
    

    void Awake()
    {
        Instance = this;
    }
    //play sound when called
    public void PlaySoundOnce(AudioClip soundToPlay)
    {
        SFX.PlayOneShot(soundToPlay);
    }
}
