using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchSettings : MonoBehaviour
{
    [SerializeField] private string mainMenu = "MainMenu";
    public float delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartDelay());
    }

    private IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(delay);

        EarlyAccess();
    }

    public void EarlyAccess()
    {
        SceneManager.LoadScene(mainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
