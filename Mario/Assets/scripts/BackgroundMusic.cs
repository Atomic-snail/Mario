using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour
{

    static bool AudioBegin;
    public AudioSource source;
    void Awake()
    {
        if (!AudioBegin)
        {
            source.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}