using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcAtSpotTwo : MonoBehaviour
{
    private GameObject inSpotTwo;
    public GameObject spotOne;
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
            inSpotTwo = other.gameObject;
            other.gameObject.GetComponent<Animator>().SetBool("isMoving", false);
        }
    }

    public void moveSecondInLine()
    {
        inSpotTwo.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(spotOne.transform.position);
        inSpotTwo = null;
    }
}
