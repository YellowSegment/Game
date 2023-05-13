using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public bool interactable;
    public bool open;
    public Animator animator;
    public float delay = 3;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        interactable = false;
        open = false;
        animator.SetBool("Open", false);
        animator.SetBool("Close", false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (interactable)
        {
            animator.SetBool("Close", false);
            animator.SetBool("Open", true);
            open = true;
        }
        if (!interactable)
        {
            animator.SetBool("Open", false);
            animator.SetBool("Close", true);
            open = false;
        }
    }
}
