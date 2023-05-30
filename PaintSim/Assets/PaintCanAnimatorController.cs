using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCanAnimatorController : MonoBehaviour
{
    public Animator paintCan;
    public bool isCanOpen;
    public bool canOpen;
    private PaintCanPlace paintCanPlaceScript;
    // Start is called before the first frame update
    void Start()
    {
        paintCan.SetBool("PaintCanOpen", false);
        isCanOpen = false;
        GameObject paintCanPlaceObject = GameObject.Find("Workbench1"); // Replace with the actual name of the GameObject
        paintCanPlaceScript = paintCanPlaceObject.GetComponent<PaintCanPlace>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isCanOpen && gameObject.layer == 12 && canOpen)
        {
            paintCan.SetBool("PaintCanOpen", true);
            isCanOpen = true;
            Debug.Log("Opening can");
            paintCanPlaceScript.changeLayer(true);
            
        }
        else if (Input.GetMouseButtonDown(0) && isCanOpen && gameObject.layer == 14 && canOpen)
        {
            paintCan.SetBool("PaintCanOpen", false);
            isCanOpen = false;
            Debug.Log("Closing Can");
            paintCanPlaceScript.changeLayer(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canOpen = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canOpen = false;
    }
}
