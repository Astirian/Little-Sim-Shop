using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager core;
    public AudioClip[] trackList;
    public AudioClip currentTrack;
    public AudioSource music;

    void Awake()
    {
        if (core == null) { core = this; } 
    }

    void Start()
    {
        music = this.GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip track, float volume = 1.0f)
    {
        music.clip = track;
        currentTrack = track;
        Debug.Log("Playing track : " + currentTrack);
        
        if(!music.isPlaying) 
        { 
            music.Play();
            music.volume = volume;
        }
    }
}
