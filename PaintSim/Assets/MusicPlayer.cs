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
            audioSource.Stop();
        }

        if(!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        AudioClip thisClip = musicPlayer[Random.Range(0,musicPlayer.Count)];
        if (thisClip != null)
        {
            //Debug.Log(thisClip);
            return thisClip;
        }
        else
        {
            return null;
        }
        
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
