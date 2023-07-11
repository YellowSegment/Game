using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioController : MonoBehaviour
{

    public GameObject radioUI;
    public MusicPlayer musicPlayer;

    // Start is called before the first frame update
    void Start()
    {
        radioUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void radioSettings()
    {
        radioUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void closeRadio()
    {
        radioUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void song1(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(0);
        }
        else
        {
            musicPlayer.removeAudioClip(0);
        }
    }
    public void song2(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(3);
        }
        else
        {
            musicPlayer.removeAudioClip(3);
        }
    }
    public void song3(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(2);
        }
        else
        {
            musicPlayer.removeAudioClip(2);
        }
    }
    public void song4(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(3);
        }
        else
        {
            musicPlayer.removeAudioClip(3);
        }
    }
    public void song5(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(4);
        }
        else
        {
            musicPlayer.removeAudioClip(4);
        }
    }
    public void song6(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(5);
        }
        else
        {
            musicPlayer.removeAudioClip(5);
        }
    }
    public void song7(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(6);
        }
        else
        {
            musicPlayer.removeAudioClip(6);
        }
    }
    public void song8(bool isOn)
    {
        if (isOn == true)
        {
            musicPlayer.addAudioClip(7);
        }
        else
        {
            musicPlayer.removeAudioClip(7);
        }
    }

}
