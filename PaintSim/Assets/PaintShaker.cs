using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintShaker : MonoBehaviour
{
    public bool interactable;
    public bool running;
    public Animator animator;
    public float delay = 3;
    public float cooldown = 1.5f; // added cooldown period of 1.5 seconds
    private float timer;
    private float cooldownTimer; // added cooldown timer

    // Start is called before the first frame update
    void Start()
    {
        interactable = false;
        running = false;
        animator.SetBool("startRun", false);
        animator.SetBool("stopRun", false);

        // Add an event to the animation that triggers the OnAnimationFinish method
        AnimationClip clip = animator.runtimeAnimatorController.animationClips[0];
        AnimationEvent evt = new AnimationEvent();
        evt.time = clip.length;
        evt.functionName = "OnAnimationFinish";
        clip.AddEvent(evt);
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

    // Method called when the animation finishes playing
    void OnAnimationFinish()
    {
        animator.SetBool("startRun", false);
        animator.SetBool("stopRun", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer > 0) // check if cooldown period is still active
        {
            cooldownTimer -= Time.deltaTime;
            return; // exit early if cooldown period is still active
        }

        if (interactable && Input.GetKeyDown(KeyCode.E) && !running)
        {
            animator.SetBool("startRun", true);
            running = true;
            timer = 0;

            cooldownTimer = cooldown; // start cooldown period
        }
        if (running)
        {
            timer += Time.deltaTime;
            if (timer > delay)
            {
                running = false;
                animator.SetBool("stopRun", true);
            }
        }
    }
}
