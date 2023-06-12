using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellPaint : MonoBehaviour
{
    private GameObject paintCan;
    private bool paintCanPlaced;
    private PaintCanAnimatorController tintGetter;
    public GameObject orderCreation;
    private PaintOrder paintOrder;
    int score = 0;
    private int redNeeded;
    private int redInCan;
    private int greenNeeded;
    private int greenInCan;
    private int blueNeeded;
    private int blueInCan;

    void Start()
    {
        paintCan = null;
        tintGetter = null;
        paintOrder = orderCreation.GetComponent<PaintOrder>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PaintCan"))
        {
            paintCan = other.gameObject;
            Debug.Log(paintCan);
            paintCanPlaced = true;
            tintGetter = paintCan.GetComponent<PaintCanAnimatorController>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PaintCan"))
        {
            paintCanPlaced = false;
            paintCan = null;
            tintGetter = null;
        }
    }

    void Update()
    {
        if (paintCanPlaced && Input.GetKeyDown(KeyCode.F))
        {
            score = 0;
            redNeeded = paintOrder.getRed();
            redInCan = tintGetter.getTotalRedTintInCan();
            greenNeeded = paintOrder.getGreen();
            greenInCan = tintGetter.getTotalGreenTintInCan();
            blueNeeded = paintOrder.getBlue();
            blueInCan = tintGetter.getTotalBlueTintInCan();
            if (redNeeded == redInCan)
            {
                score += 3;
            }
            else if (redNeeded <= redInCan+3 && redNeeded >= redInCan-3)
            {
                score += 2;
            }
            else if (redNeeded <= redInCan+10 && redNeeded >= redInCan-10)
            {
                score += 1;
            }

            if (greenNeeded == greenInCan)
            {
                score += 3;
            }
            else if (greenNeeded <= greenInCan+3 && greenNeeded >= greenInCan-3)
            {
                score += 2;
            }
            else if (greenNeeded <= greenInCan+10 && greenNeeded >= greenInCan-10)
            {
                score += 1;
            }

            if (blueNeeded == blueInCan)
            {
                score += 3;
            }
            else if (blueNeeded <= blueInCan+3 && blueNeeded >= blueInCan-3)
            {
                score += 2;
            }
            else if (blueNeeded <= blueInCan+10 && blueNeeded >= blueInCan-10)
            {
                score += 1;
            }


            if (score == 9)
            {
                Debug.Log("GREAT JOB PERFECT - 9");
            }
            else if (score == 8)
            {
                Debug.Log("Missed by a little - 8");
            }
            else if (score == 7)
            {
                Debug.Log("Missed by a little - 7");
            }
            else if (score == 6)
            {
                Debug.Log("Missed a bit - 6");
            }
            else if (score == 5)
            {
                Debug.Log("Missed a bit - 5");
            }
            else if (score == 4)
            {
                Debug.Log("Missed a good bit - 4");
            }
            else if (score == 3)
            {
                Debug.Log("You missed a lot - 3");
            }
            else if (score == 2)
            {
                Debug.Log("You missed a lot - 2");
            }
            else if (score == 1)
            {
                Debug.Log("You barely even did anything - 1");
            }
            else if (score == 0)
            {
                Debug.Log("What the hell did you do. - 0");
            }
            paintCan.SetActive(false);
        }
    }
}
