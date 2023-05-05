using UnityEngine;
using UnityEngine.UI;
 
public class AnimationStateController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if(Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);
            if (Input.GetKey("left shift"))
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isWalking", false);
        }
    }
} 
