using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcController : MonoBehaviour
{
    //Setting up the NPCs

    public GameObject[] NPCS;

    //Getting inStore positions
    public GameObject firstInLineA, secondInLine, thirdInLine;

    public bool isFirstInLineA, isFirstInLineB, isSecondInLine, isThirdInLine;

    //Starting positions and/or ending positions
    public GameObject leftWorldTrigger, rightWorldTrigger;
    public GameObject leftWorld, rightWorld;
    public GameObject doorFront;

    private bool isHeadingToStore;

    public npcAtSpotTwo npcAtSpotTwo;

    


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject npc in NPCS)
        {
            npc.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            startWalk();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            headToStore();
        }
    }

    public void startWalk()
    {
        int whichSide = Random.Range(0,2);
        if (whichSide == 1)
        {
            foreach (GameObject npc in NPCS)
            {
                if (npc.activeSelf == false)
                {
                    npc.transform.position = leftWorld.transform.position;
                    npc.SetActive(true);
                    npc.GetComponent<NavMeshAgent>().SetDestination(rightWorldTrigger.transform.position);
                    npc.GetComponent<Animator>().SetBool("isMoving", true);
                    break;
                }
            }
        }
        else
        {
            foreach (GameObject npc in NPCS)
            {
                if (npc.activeSelf == false)
                {
                    npc.transform.position = rightWorld.transform.position;
                    npc.SetActive(true);
                    npc.GetComponent<NavMeshAgent>().SetDestination(leftWorldTrigger.transform.position);
                    npc.GetComponent<Animator>().SetBool("isMoving", true);
                    break;
                }
            }
        }
    }

    public void enteredStore(GameObject theNpc)
    {
        if(!isFirstInLineA)
        {
            theNpc.GetComponent<NavMeshAgent>().SetDestination(firstInLineA.transform.position);
            isFirstInLineA = true;
        }
        else if (!isSecondInLine)
        {
            theNpc.GetComponent<NavMeshAgent>().SetDestination(secondInLine.transform.position);
            isSecondInLine = true;
        }
        // else if (!isThirdInLine)
        // {
        //     theNpc.GetComponent<NavMeshAgent>().SetDestination(thirdInLine.transform.position);
        // }
        else
        {
            int whichSide = Random.Range(0,2);
            if (whichSide == 1)
            {
                theNpc.GetComponent<NavMeshAgent>().SetDestination(leftWorldTrigger.transform.position);
            }
            else
            {
                theNpc.GetComponent<NavMeshAgent>().SetDestination(rightWorldTrigger.transform.position);
            }
            
        }
    }

    public void headToStore()
    {
        int whichSide = Random.Range(0,2);
        if (whichSide == 1)
        {
            foreach (GameObject npc in NPCS)
            {
                if (npc.activeSelf == false)
                {
                    npc.transform.position = leftWorld.transform.position;
                    npc.SetActive(true);
                    npc.GetComponent<NavMeshAgent>().SetDestination(doorFront.transform.position);
                    npc.GetComponent<Animator>().SetBool("isMoving", true);
                    npc.tag = "NPC";
                    break;
                }
            }
        }
        else
        {
            foreach (GameObject npc in NPCS)
            {
                if (npc.activeSelf == false)
                {
                    npc.transform.position = rightWorld.transform.position;
                    npc.SetActive(true);
                    npc.GetComponent<NavMeshAgent>().SetDestination(doorFront.transform.position);
                    npc.GetComponent<Animator>().SetBool("isMoving", true);
                    npc.tag = "NPC";
                    break;
                }
            }
        }
    }

    public void updateQueue(GameObject npc)
    {
        npc.GetComponent<NavMeshAgent>().SetDestination(rightWorldTrigger.transform.position);
        isFirstInLineA = false;
        Debug.Log(isSecondInLine);
        if (isSecondInLine)
        {
            isSecondInLine = false;
            npcAtSpotTwo.moveSecondInLine();
            isFirstInLineA = true;
        }
    }

    // public void getIsFirst(bool isFirst)
    // {
    //     firstInLineA = isFirst;
    // }
    // public void getIsSecond(bool isSecond)
    // {
    //     secondInLine = isSecond;
    // }
    // public void getIsThird(bool isThird)
    // {
    //     thirdInLine = isThird;
    // }
}
