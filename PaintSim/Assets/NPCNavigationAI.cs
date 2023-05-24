using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavigationAI : MonoBehaviour
{
    public GameObject walkPastDestination;
    public GameObject positionOne, positionTwo, positionThree, positionFour, positionFive;
    NavMeshAgent theAgent;
    public bool isPositionOne, isPositionTwo, isPositionThree, isPositionFour, isPositionFive = false;
    private int walkDirection;
    public int customerChance;
    public float chanceFrequency;
    private float time;
    public Animator animator;
    private float walkPastTime = 30f;
    private bool isWalking;
    private float walkTime;
    private int startMovement;
    public GameObject npc;
    public bool inStore;

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        customerChance = 5;
        chanceFrequency = 10f;
        time = chanceFrequency;
        PauseAnimator();
        isWalking = false;
        walkTime = walkPastTime;
        npc.SetActive(false);
        isPositionOne = false;
    }

    // Update is called once per frame
    void Update()
    {
        walkTime -= Time.deltaTime;
        if (walkTime < 0)
        {
            isWalking = false;
        }
        if (!isWalking)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                walkTime = walkPastTime;
                time = chanceFrequency;
                ChooseDestination();
            }
        }
    }

    public void ChooseDestination()
    {
        startMovement = Random.Range(0, customerChance);
        if (startMovement == 0)
        {
            npc.SetActive(true);
            walkDirection = Random.Range(0, customerChance);
            isWalking = true;
            Debug.Log(walkDirection);
            unPauseAnimator();
            if (walkDirection == 0)
            {
                inStore = true;
                if (!isPositionOne)
                {
                    theAgent.SetDestination(positionOne.transform.position);
                    isWalking = true;
                    isPositionOne = true;
                    walkDirection = -1;
                }
                else if (!isPositionTwo)
                {
                    theAgent.SetDestination(positionTwo.transform.position);
                    isWalking = true;
                    isPositionTwo = true;
                    walkDirection = -1;
                }
                else if (!isPositionThree)
                {
                    theAgent.SetDestination(positionThree.transform.position);
                    isWalking = true;
                    isPositionThree = true;
                    walkDirection = -1;
                }
                else if (!isPositionFour)
                {
                    theAgent.SetDestination(positionFour.transform.position);
                    isWalking = true;
                    isPositionFour = true;
                    walkDirection = -1;
                }
                else if (!isPositionFive)
                {
                    theAgent.SetDestination(positionFive.transform.position);
                    isWalking = true;
                    isPositionFive = true;
                    walkDirection = -1;
                }
                else
                {
                    theAgent.SetDestination(walkPastDestination.transform.position);
                    isWalking = true;
                    walkDirection = -1;
                }
            }
            else
            {
                theAgent.SetDestination(walkPastDestination.transform.position);
                isWalking = true;
                walkDirection = -1;
            }
        }
    }

    public void setCustomerChance(int customerChance)
    {
        this.customerChance = customerChance;
    }

    public void PauseAnimator()
    {
        animator.speed = 0f;
    }
    public void unPauseAnimator()
    {
        animator.speed = 1f;
    }
}
