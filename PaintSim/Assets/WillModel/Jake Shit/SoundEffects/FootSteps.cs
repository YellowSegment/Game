using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip[] walkingSounds;
    public AudioClip[] sprintingSounds;

    public AudioSource walkingAudioSource;
    public AudioSource sprintingAudioSource;

    public float walkStepDelay = 0.5f; // The delay between footsteps when walking
    public float sprintStepDelay = 0.2f; // The delay between footsteps when sprinting

    private bool isSprinting;
    private float stepDelay;

    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftControl))
        {// Check if any movement key is pressed
            bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

            // Check if sprint key is pressed
            isSprinting = Input.GetKey(KeyCode.LeftShift);

            // Stop walking sound if not moving or sprinting
            if (!isMoving || isSprinting)
            {
                walkingAudioSource.Stop();
            }

            // Play walking sound if moving and not sprinting
            if (isMoving && !isSprinting)
            {
                if (!walkingAudioSource.isPlaying)
                {
                    walkingAudioSource.clip = walkingSounds[Random.Range(0, walkingSounds.Length)];
                    walkingAudioSource.Play();
                }
            }

            // Play sprinting sound if moving and sprinting
            if (isMoving && isSprinting)
            {
                if (!sprintingAudioSource.isPlaying)
                {
                    sprintingAudioSource.clip = sprintingSounds[Random.Range(0, sprintingSounds.Length)];
                    sprintingAudioSource.Play();
                }
            }

            // Stop sprinting sound if not moving or not sprinting
            if ((!isMoving || !isSprinting) && sprintingAudioSource.isPlaying)
            {
                sprintingAudioSource.Stop();
            }
        }
        else
        {
            walkingAudioSource.Stop();
            sprintingAudioSource.Stop();
        }
    }
}
