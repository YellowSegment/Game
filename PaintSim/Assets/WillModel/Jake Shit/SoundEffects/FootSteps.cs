using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource walkingFootstepsSound;
    public AudioSource sprintingFootstepsSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walkingFootstepsSound.enabled = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprintingFootstepsSound.enabled = true;
            }
            else
            {
                sprintingFootstepsSound.enabled = false;
            }
        }
        else
        {
            walkingFootstepsSound.enabled = false;
        }
    }
}
