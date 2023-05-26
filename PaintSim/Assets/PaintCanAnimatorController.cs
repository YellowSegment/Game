using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCanAnimatorController : MonoBehaviour
{
    public Animator paintCan;
    public bool isCanOpen;
    public bool canOpen;
    // Start is called before the first frame update
    void Start()
    {
        paintCan.SetBool("PaintCanOpen", false);
        isCanOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isCanOpen && gameObject.layer == 0 && canOpen)
        {
            paintCan.SetBool("PaintCanOpen", true);
            isCanOpen = true;
            Debug.Log("Opening can");
        }
        else if (Input.GetKeyDown(KeyCode.E) && isCanOpen && gameObject.layer == 0 && canOpen)
        {
            paintCan.SetBool("PaintCanOpen", false);
            isCanOpen = false;
            Debug.Log("Closing Can");
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
