using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    private List<AudioClip> musicPlayer = new List<AudioClip>();
    private List<AudioClip> musicPlayerStatic = new List<AudioClip>();

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        foreach (AudioClip song in clips)
        {
            musicPlayer.Add(song);
            musicPlayerStatic.Add(song);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            removeAudioClip(1);
            Debug.Log(musicPlayer[1]);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            addAudioClip(1);
            Debug.Log(musicPlayer[1]);
        }

        if(!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        return musicPlayer[Random.Range(0,musicPlayer.Count)];
    }

    public void removeAudioClip(int songNumber)
    {
        musicPlayer[songNumber] = null;
    }

    public void addAudioClip(int songNumber)
    {
        musicPlayer[songNumber] = musicPlayerStatic[songNumber];
    }
}
