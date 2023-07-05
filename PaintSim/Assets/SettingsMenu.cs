using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer MusicVolume;
    public AudioMixer VoiceVolume;
    public AudioMixer soundEffects;
    public AudioMixer notifications;

    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;
    public Text musicVolumeText;
    public Text voiceVolumeText;
    public Text soundEffectsText;
    public Text notificationsText;

    public GameObject AudioSettings;
    public GameObject videoSettings;
    public GameObject gameplaySettings;

    public float musicVolumefloat;
    public float VoiceVolumefloat;
    public float soundEffectsFloat;
    public float notificationsFloat;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " @" + resolutions[i].refreshRate + "Hz";
            options.Add(new TMP_Dropdown.OptionData(option));

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        
        musicVolumeText.text = getMusicVolume().ToString();
        voiceVolumeText.text = getVoiceVolume().ToString();
        soundEffectsText.text = getSoundEffects().ToString();
        notificationsText.text = getNotificationsFloat().ToString();
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    void Update()
    {
        //IMPLEMENT AUTOSAVE
    }
    
    public void clickAudioSettings()
    {
        AudioSettings.SetActive(true);
        videoSettings.SetActive(false);
        gameplaySettings.SetActive(false);
    }
    public void clickVideoSettings()
    {
        AudioSettings.SetActive(false);
        videoSettings.SetActive(true);
        gameplaySettings.SetActive(false);
    }
    public void clickGamePlaySettings()
    {
        AudioSettings.SetActive(false);
        videoSettings.SetActive(false);
        gameplaySettings.SetActive(true);
    }

    public void SetMusicVolume(float volume)
    {
        MusicVolume.SetFloat("MusicVolume", volume);
        int tempInt = (int)(volume+95);
        musicVolumeText.text = tempInt.ToString();
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void SetVoiceVolume(float volume)
    {
        VoiceVolume.SetFloat("MusicVolume", volume);
        voiceVolumeText.text = volume.ToString();
    }

    public void SetSoundEffectVolume(float volume)
    {
        soundEffects.SetFloat("SoundEffects", volume);
        soundEffectsText.text = volume.ToString();
    }

    public void SetNoticationVolume(float volume)
    {
        notifications.SetFloat("Notifications", volume);
        notificationsText.text = volume.ToString();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetMaxFps(int maxFps)
    {
        Application.targetFrameRate = maxFps;
    }

    public void SetAutoSaveFrequency()
    {
        // Implement auto-save frequency setting
    }

    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public float getMusicVolume()
    {
        return musicVolumefloat;
    }
    public float getNotificationsFloat()
    {
        return notificationsFloat;
    }
    public float getSoundEffects()
    {
        return soundEffectsFloat;
    }
    public float getVoiceVolume()
    {
        return VoiceVolumefloat;
    }
}
