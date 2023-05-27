using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class PaintCanPlace : MonoBehaviour
{
    public GameObject[] paintCans;  // Array of possible paint cans
    public GameObject paintCanPlacementWorkbench1;
    // public GameObject paintCanPlacementWorkbench2a;
    // public GameObject paintCanPlacementWorkbench2b;
    public bool isPaintCan;
    public GameObject promptUI;
    public bool isPaintPlaced;
    public GameObject grabPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (IsPaintCan(other.gameObject))
        {
            isPaintCan = true;
            promptUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsPaintCan(other.gameObject))
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
            ObjectGrabable grabbable = paintCans[0].GetComponent<ObjectGrabable>();
            if (grabbable != null)
            {
                grabbable.Drop();
            }
            paintCans[0].transform.position = paintCanPlacementWorkbench1.transform.position;
            paintCans[0].transform.rotation = paintCanPlacementWorkbench1.transform.rotation;
            isPaintPlaced = true;
            paintCans[0].layer = 0;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                ObjectGrabable grabbable = paintCans[0].GetComponent<ObjectGrabable>();
                if (grabbable != null)
                { 
                    grabbable.Grab(grabPoint.transform);
                    isPaintPlaced = false;
                    paintCans[0].layer = 7;
                }
            }
        }
    }

    private bool IsPaintCan(GameObject obj)
    {
        foreach (GameObject paintCan in paintCans)
        {
            if (obj == paintCan)
            {
                return true;
            }
        }
        return false;
    }
}
