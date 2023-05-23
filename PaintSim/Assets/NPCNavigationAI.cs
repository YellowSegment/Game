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

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        customerChance = 2;
        chanceFrequency = 10f;
        time = chanceFrequency;
        PauseAnimator();
        isWalking = false;
        walkTime = walkPastTime;
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
        walkDirection = Random.Range(0, customerChance);
        isWalking = true;
        Debug.Log(walkDirection);
        unPauseAnimator();
        if (walkDirection == 0)
        {
            if (isPositionOne)
            {
                theAgent.SetDestination(positionOne.transform.position);
            }
            else if (isPositionTwo)
            {
                theAgent.SetDestination(positionTwo.transform.position);
            }
            else if (isPositionThree)
            {
                theAgent.SetDestination(positionThree.transform.position);
            }
            else if (isPositionFour)
            {
                theAgent.SetDestination(positionFour.transform.position);
            }
            else if (isPositionFive)
            {
                theAgent.SetDestination(positionFive.transform.position);
            }
            else
            {
                theAgent.SetDestination(walkPastDestination.transform.position);
            }
        }
        else
        {
            theAgent.SetDestination(walkPastDestination.transform.position);
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
