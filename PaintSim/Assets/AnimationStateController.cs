using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool backwardsPressed = Input.GetKey("s");
        bool isSprinting = Input.GetKey("left shift");
        //bool isCrouching = Input.GetKey("Left Control");
        //if (!isCrouching)
        //{
            // if (forwardPressed && !isSprinting)
            // {
            //     animator.SetBool("isWalking", true);
            // }
            // if (!forwardPressed && !isSprinting)
            // {
            //     animator.SetBool("isWalking", false);
            // }
            // if (forwardPressed && isSprinting)
            // {
            //     animator.SetBool("isRunning", true);
            // }
            // if (!forwardPressed && !isSprinting)
            // {
            //     animator.SetBool("isRunning", false);
            // }
            // if (forwardPressed && leftPressed)
            // {
            //     animator.SetBool("isWalkingForwardLeft", true);
            // }
            // if (!forwardPressed && !leftPressed)
            // {
            //     animator.SetBool("isWalkingForwardLeft", false);
            // }
            // if (forwardPressed && rightPressed)
            // {
            //     animator.SetBool("isWalkingForwardRight", true);
            // }
            // if (!forwardPressed && !rightPressed)
            // {
            //     animator.SetBool("isWalkingForwardRight", false);
            // }
        //}
    }
}
