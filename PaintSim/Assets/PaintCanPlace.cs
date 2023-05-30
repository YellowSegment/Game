using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class PaintCanPlace : MonoBehaviour
{
    public GameObject paintCanPlacementWorkbench1;
    public GameObject promptUI;
    public bool isPaintPlaced;
    public GameObject grabPoint;
    public bool canPickup;

    private GameObject objectToPlace;  // The object you want to place

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PaintCan") && !isPaintPlaced)
        {
            objectToPlace = other.gameObject;
            promptUI.SetActive(true);
        }
        if (other.CompareTag("Player") && isPaintPlaced)
        {
            canPickup = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PaintCan") && !isPaintPlaced)
        {
            objectToPlace = null;
            promptUI.SetActive(false);
        }
        if (other.CompareTag("Player") && isPaintPlaced)
        {
            canPickup = false;
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        promptUI.SetActive(false);
        isPaintPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && promptUI.activeSelf)
        {
            MoveObjectToPlace();
        }
        if (Input.GetKeyDown(KeyCode.F) && canPickup)
        {
            Pickup();
        }
    }

    private void MoveObjectToPlace()
    {
        if (!isPaintPlaced && objectToPlace != null)
        {
            ObjectGrabable grabbable = objectToPlace.GetComponent<ObjectGrabable>();
            if (grabbable != null)
            {
                grabbable.Drop();
            }
            objectToPlace.transform.position = paintCanPlacementWorkbench1.transform.position;
            objectToPlace.transform.rotation = paintCanPlacementWorkbench1.transform.rotation;
            Rigidbody rb = objectToPlace.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            isPaintPlaced = true;
            promptUI.SetActive(false);
            objectToPlace.layer = 12;  // Assuming 12 is the desired layer index
        }
    }
    private void Pickup()
    {
        if(isPaintPlaced && canPickup && objectToPlace.layer != 14)
        {
            Rigidbody rb = objectToPlace.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            isPaintPlaced = false;
            ObjectGrabable grabbable = objectToPlace.GetComponent<ObjectGrabable>();
            if (grabbable != null)
            {
                grabbable.Grab(grabPoint.transform);
            }
            objectToPlace.layer = 7;  // Assuming 12 is the desired layer index
            canPickup = false;
        }
    }

    public bool canPourTint()
    {
        bool canPour = false;
        return canPour;
    }

    public void changeLayer(bool layerOpen)
    {
        if (layerOpen)
        {
            objectToPlace.layer = 14;
            canPickup = false;
        }
        else
        {
            objectToPlace.layer = 12;
            canPickup = true;
        }
    }

}
