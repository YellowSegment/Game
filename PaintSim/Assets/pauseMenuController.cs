using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuController : MonoBehaviour
{
    
    public GameSaveLoadController saveLoadController;
    public GameObject settingsUI;
    public GameObject pausePannelUI;

    void Start()
    {
        
    }
    void Update()
    {
        if (settingsUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            settingsUI.SetActive(false);
            pausePannelUI.SetActive(true);
        }
    }

    public void backButton()
    {
        settingsUI.SetActive(false);
        pausePannelUI.SetActive(true);
    }
    
    public void SaveGame()
    {
        saveLoadController.Save();
    }

    public void LoadGame()
    {
        saveLoadController.Load();
    }
    
    public void openSettings()
    {
        pausePannelUI.SetActive(false);
        settingsUI.SetActive(true);
    }
    public void QuitToDesktop()
    {
        saveLoadController.Save();
        Application.Quit();
    }
}
