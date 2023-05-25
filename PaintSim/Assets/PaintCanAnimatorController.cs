using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCanAnimatorController : MonoBehaviour
{
    public Animator paintCan;
    public bool isCanOpen;
    // Start is called before the first frame update
    void Start()
    {
        paintCan.SetBool("PaintCanOpen", false);
        isCanOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isCanOpen)
        {
            paintCan.SetBool("PaintCanOpen", true);
            isCanOpen = true;
            Debug.Log("Opening can");
        }
        else if (Input.GetKeyDown(KeyCode.E) && isCanOpen)
        {
            paintCan.SetBool("PaintCanOpen", false);
            isCanOpen = false;
            Debug.Log("Closing Can");
        }
    }
}
