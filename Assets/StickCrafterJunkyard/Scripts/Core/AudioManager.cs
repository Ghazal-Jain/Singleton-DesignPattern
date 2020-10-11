using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    public AudioClip audioTrack;

    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("Audio Manager");
                obj.AddComponent<AudioManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        PlayAudioTrack();
    }

    private void PlayAudioTrack()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioTrack;
        audioSource.Play();

    }
}
