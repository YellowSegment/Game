using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcAtSpotOne : MonoBehaviour
{

    public npcAtSpotTwo npcAtSpotTwo;
    public npcAtSpotThree npcAtSpotThree;
    public NpcController npcController;
    public PaintOrder paintOrder;

    private GameObject inSpotOne;
    private int totalInStore;
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
            paintOrder.CreateOrder();
            other.gameObject.GetComponent<Animator>().SetBool("isMoving", false);
            inSpotOne = other.gameObject;
        }
    }

    public void itemSold()
    {
        npcController.updateQueue(inSpotOne);
        inSpotOne.tag = "NPCDone";
        inSpotOne = null;
    }

}
