using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIScript : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject MainMenu;
    public GameObject Credits;
    private bool SettingsOpen = false;
    [SerializeField] private string NewGameLevel = "World1";


    public void NewGameButton()
    {
        SceneManager.LoadScene(NewGameLevel);
    }

    public void OpenSettings()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
        SettingsOpen = true;
    }

    public void CloseSettings()
    {
        SettingsOpen = false;
        SettingsMenu.SetActive(false);
         MainMenu.SetActive(true);
    }
   void Update()
   {
        if (SettingsOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseSettings();
        }
   }
}
