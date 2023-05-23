using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBoxTeleport : MonoBehaviour
{
    public Transform telportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = telportTarget.transform.position;
    }
}
