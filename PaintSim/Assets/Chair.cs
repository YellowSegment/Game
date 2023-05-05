using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public Transform sitPoint;
    public float sitRotationOffset = 0f;
    public LayerMask playerLayerMask;
    public KeyCode interactKey = KeyCode.E;

    private bool isSitting = false;
    private GameObject playerObject = null;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool isPlayerInTrigger = false;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            isPlayerInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            isPlayerInTrigger = false;
        }
    }

    void Update()
    {
        if (!isSitting && Input.GetKeyDown(interactKey) && isPlayerInTrigger)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, 1f, playerLayerMask);
            if (colliders.Length > 0)
            {
                playerObject = colliders[0].gameObject;
                playerObject.transform.position = sitPoint.position;
                playerObject.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, sitRotationOffset, 0f));
                playerObject.GetComponent<CharacterController>().enabled = false;
                isSitting = true;
            }
        }
        else if (isSitting && Input.GetKeyDown(interactKey))
        {
            playerObject.transform.position = originalPosition;
            playerObject.transform.rotation = originalRotation;
            playerObject.GetComponent<CharacterController>().enabled = true;
            playerObject = null;
            isSitting = false;
        }
        
        // Add the following lines to keep the player seated in the chair
        if (isSitting && playerObject != null)
        {
            playerObject.transform.position = sitPoint.position;
            playerObject.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, sitRotationOffset, 0f));
        }
    }
}
