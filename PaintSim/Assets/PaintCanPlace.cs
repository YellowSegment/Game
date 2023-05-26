using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class PaintCanPlace : MonoBehaviour
{
    public GameObject paintCan;
    public GameObject paintCanPlacementWorkbench1;
    // public GameObject paintCanPlacementWorkbench2a;
    // public GameObject paintCanPlacementWorkbench2b;
    public bool isPaintCan;
    public GameObject promptUI;
    public bool isPaintPlaced;
    public GameObject grabPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == paintCan)
        {
            isPaintCan = true;
            promptUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == paintCan)
        {
            isPaintCan = false;
            promptUI.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        promptUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isPaintCan)
        {
            MovePaintCan();
        }
    }

    private void MovePaintCan()
    {
        
        if (!isPaintPlaced)
        {
            promptUI.SetActive(false);
            ObjectGrabable grabbable = paintCan.GetComponent<ObjectGrabable>();
            if (grabbable != null)
            {
                grabbable.Drop();
            }
            paintCan.transform.position = paintCanPlacementWorkbench1.transform.position;
            paintCan.transform.rotation = paintCanPlacementWorkbench1.transform.rotation;
            isPaintPlaced = true;
            paintCan.layer = 0;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                ObjectGrabable grabbable = paintCan.GetComponent<ObjectGrabable>();
                if (grabbable != null)
                { 
                    grabbable.Grab(grabPoint.transform);
                    isPaintPlaced = false;
                    paintCan.layer = 7;

                }
            }
        }
    }
}
