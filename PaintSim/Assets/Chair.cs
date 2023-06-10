using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject playerStanding;
    public GameObject playerSitting;
    public GameObject UItext;
    public GameObject Desktop;
    public GameObject LeavePC;
    public Camera standingCamera;
    public Camera sittingCamera;
    public bool interactable;
    public bool sitting;
    public bool onPC;
    private ButtonUI buttonUI;
    public GameObject buttonUiGameObject;
    void Start()
    {
        // Initialize variables
        interactable = false;
        sitting = false;
        UItext.SetActive(false);
        Desktop.SetActive(false);
        onPC = false;
        buttonUI = buttonUiGameObject.GetComponent<ButtonUI>();
        // Set standing camera to main camera if not assigned
        if (standingCamera == null)
        {
            standingCamera = Camera.main;
        }

        // Set sitting camera to main camera if not assigned
        if (sittingCamera == null)
        {
            sittingCamera = Camera.main;
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
            if (sittingCamera == null)
            {
                return;
            }

            if (onPC)
            {
                UItext.SetActive(false);
                LeavePC.SetActive(true);
            }
            else
            {
                UItext.SetActive(true);
                LeavePC.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.E) && !onPC)
            {
                playerSitting.SetActive(false);
                playerStanding.SetActive(true);
                standingCamera.enabled = true;
                if (sittingCamera != null && sittingCamera.GetComponent<Camera>() != null)
                {
                    sittingCamera.GetComponent<Camera>().enabled = false;
                }
                sitting = false;
                UItext.SetActive(false);

                // disable the audio listener and camera on the sitting camera, and enable them on the main camera
                Camera.main.GetComponent<Camera>().enabled = true;
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Desktop.SetActive(true);
                onPC = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            if (onPC && Input.GetKeyDown(KeyCode.Escape) && !buttonUI.getOnSite())
            {
                Desktop.SetActive(false);
                onPC = false;
                UItext.SetActive(true);
                LeavePC.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
