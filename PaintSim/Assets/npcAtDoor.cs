using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcAtDoor : MonoBehaviour
{
    public NpcController npcController;
    public TriggerDoorController triggerDoorController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            npcController.enteredStore(other.gameObject);
            triggerDoorController.npcEntering();
        }
        if (other.CompareTag("NPCDone"))
        {
            triggerDoorController.npcEntering();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            triggerDoorController.npcExiting();
        }
        if (other.CompareTag("NPCDone"))
        {
            triggerDoorController.npcExiting();
        }
    }
}
