using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintCanAnimatorController : MonoBehaviour
{
    public Animator paintCan;
    public bool isCanOpen;
    public bool canOpen;
    private PaintCanPlace paintCanPlaceScript;
    public GameObject openUI;
    public GameObject closedUI;
    private TintChoiceController tintController;
    public GameObject tintUI;

    // Start is called before the first frame update
    void Start()
    {
        paintCan.SetBool("PaintCanOpen", false);
        isCanOpen = false;

        GameObject paintCanPlaceObject = GameObject.Find("Workbench1"); // Replace with the actual name of the GameObject
        paintCanPlaceScript = paintCanPlaceObject.GetComponent<PaintCanPlace>();

        tintController = tintUI.GetComponent<TintChoiceController>();

        openUI.SetActive(false);
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
            openUI.SetActive(true);
            closedUI.SetActive(false);
            tintController.SelectRedTint();
        }
        else if (Input.GetKeyDown(KeyCode.E) && isCanOpen && gameObject.layer == 14 && canOpen)
        {
            paintCan.SetBool("PaintCanOpen", false);
            isCanOpen = false;
            Debug.Log("Closing Can");
            paintCanPlaceScript.changeLayer(false);
            openUI.SetActive(false);
            closedUI.SetActive(true);
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
