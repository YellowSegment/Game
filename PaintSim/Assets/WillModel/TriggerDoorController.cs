using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    private bool isDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger && !isDoorOpen)
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                isDoorOpen = true;
            }
        }
    } 

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger && isDoorOpen)
            {
                myDoor.Play("DoorClose", 0, 0.0f);
                isDoorOpen = false;
            }
        }
    } 
}
