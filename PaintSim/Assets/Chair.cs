using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject playerStanding;
    public GameObject playerSitting;
    public Camera standingCamera;
    public Camera sittingCamera;
    public bool interactable;
    public bool sitting;

    void Start()
    {
        // Initialize variables
        interactable = false;
        sitting = false;

        // Set standing camera to main camera if not assigned
        if (standingCamera == null)
        {
            standingCamera = Camera.main;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = false;
        }
    }

    void Update()
{
    if (interactable)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerSitting.SetActive(true);
            sitting = true;
            playerStanding.SetActive(false);
            if (standingCamera != null)
            {
                standingCamera.enabled = false;
            }
            if (sittingCamera != null && sittingCamera.GetComponent<Camera>() != null)
            {
                sittingCamera.GetComponent<Camera>().enabled = true;
            }
            interactable = false;

            // disable the audio listener and camera on the main camera, and enable them on the sitting camera
            Camera.main.GetComponent<Camera>().enabled = false;
            if (sittingCamera?.GetComponent<Camera>() != null)
            {
                sittingCamera.GetComponent<Camera>().enabled = true;
            }
        }
    }

    if (sitting)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerSitting.SetActive(false);
            playerStanding.SetActive(true);
            standingCamera.enabled = true;
            if (sittingCamera != null && sittingCamera.GetComponent<Camera>() != null)
            {
                sittingCamera.GetComponent<Camera>().enabled = false;
            }
            sitting = false;

            // disable the audio listener and camera on the sitting camera, and enable them on the main camera
            Camera.main.GetComponent<Camera>().enabled = true;
        }
    }
}

}
