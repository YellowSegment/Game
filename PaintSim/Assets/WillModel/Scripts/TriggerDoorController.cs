using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    public Animator myDoor;
    public bool isDoorOpen;
    public bool interactable;
    public float delay = 3;
    private float timer;
    public BoxCollider doorCollider;

    void Start()
    {
        interactable = false;
        myDoor.SetBool("DoorOpen", false);
        myDoor.SetBool("DoorClose", false);
        isDoorOpen = false;
        doorCollider.enabled = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactable = true;
        }
    } 

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactable = false;
        }
    } 

    public void npcEntering()
    {
        myDoor.SetBool("DoorOpen", true);
        myDoor.SetBool("DoorClose", false);
        isDoorOpen = true;
        timer = 0;
        doorCollider.enabled = false;
    }
    public void npcExiting()
    {
        timer += Time.deltaTime;
            if (timer > delay)
            {
                myDoor.SetBool("DoorClose", true);
                myDoor.SetBool("DoorOpen", false);
                isDoorOpen = false;
                doorCollider.enabled = true;
            }
    }

    void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.E))
        {
            myDoor.SetBool("DoorOpen", true);
            myDoor.SetBool("DoorClose", false);
            isDoorOpen = true;
            timer = 0;
            doorCollider.enabled = false;
        }

        if (!interactable)
        {
            timer += Time.deltaTime;
            if (timer > delay)
            {
                myDoor.SetBool("DoorClose", true);
                myDoor.SetBool("DoorOpen", false);
                isDoorOpen = false;
                doorCollider.enabled = true;
            }
        }
    }
}
