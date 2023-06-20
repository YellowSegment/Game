using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endDayTriggerController : MonoBehaviour
{
    public GameObject endOfDayKeyPressText;
    //public GameObject resetPosition;
    private bool isPlayerIn;
    public DayEndController dayEndController;
    
    // Start is called before the first frame update
    void Start()
    {
        endOfDayKeyPressText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerIn & Input.GetKeyDown(KeyCode.F))
        {
            dayEndController.endOfDay();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endOfDayKeyPressText.SetActive(true);
            isPlayerIn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endOfDayKeyPressText.SetActive(false);
            isPlayerIn = false;
        }
    }

}
