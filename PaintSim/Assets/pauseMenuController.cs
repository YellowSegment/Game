using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuController : MonoBehaviour
{
    
    public GameSaveLoadController saveLoadController;

    void Start()
    {
        
    }
    void Update()
    {
        
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

    }
    public void QuitToDesktop()
    {
        saveLoadController.Save();
        Application.Quit();
    }
}
