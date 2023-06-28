using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellPaint : MonoBehaviour
{
    private GameObject paintCan;
    private bool paintCanPlaced;
    private PaintMixer tintGetter;
    public GameObject orderCreation;
    private PaintOrder paintOrder;
    int score = 0;
    private int redNeeded;
    private int redInCan;
    private int greenNeeded;
    private int greenInCan;
    private int blueNeeded;
    private int blueInCan;
    public GameObject balanceControllerObject;
    private BalanceController balanceController;
    public int totalRGB;
    private double price;
    public GameObject inventoryManagerObject;
    private InventoryManager inventoryManager;
    private PaintCanAnimatorController paintcanAnimator;
    private bool notSold;
    public GameObject soldItem;

    void Start()
    {
        soldItem.SetActive(false);
        inventoryManager = inventoryManagerObject.GetComponent<InventoryManager>();
        paintCan = null;
        tintGetter = null;
        paintcanAnimator = null;
        paintOrder = orderCreation.GetComponent<PaintOrder>();
        balanceController = balanceControllerObject.GetComponent<BalanceController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PaintCan"))
        {
            paintCan = other.gameObject;
            Debug.Log(paintCan);
            paintCanPlaced = true;
            tintGetter = paintCan.GetComponent<PaintMixer>();
            paintcanAnimator = paintCan.GetComponent<PaintCanAnimatorController>();
            notSold = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PaintCan"))
        {
            paintCanPlaced = false;
            paintCan = null;
            tintGetter = null;
            paintcanAnimator = null;
        }
    }

    IEnumerator DisplaySell()
    {
        soldItem.SetActive(true);
        yield return new WaitForSeconds(5);
        soldItem.SetActive(false);
    }
    void Update()
    {
        if (paintCanPlaced && Input.GetKeyDown(KeyCode.F) && notSold)
        {
            notSold = false;
            score = 0;
            redNeeded = paintOrder.getRed();
            redInCan = tintGetter.getRedTintAmount();
            greenNeeded = paintOrder.getGreen();
            greenInCan = tintGetter.getGreenTintAmount();
            blueNeeded = paintOrder.getBlue();
            blueInCan = tintGetter.getBlueTintAmount();
            
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

            totalRGB = blueInCan + redInCan + greenInCan;
            if (totalRGB >= 700)
            {
                price = 30.99;
            }
            else if (totalRGB >= 600)
            {
                price = 27.99;
            }
            else if (totalRGB >= 500)
            {
                price = 24.99;
            }
            else if (totalRGB >= 400)
            {
                price = 21.99;
            }
            else if (totalRGB >= 300)
            {
                price = 19.99;
            }
            else if (totalRGB >= 200)
            {
                price = 17.99;
            }
            else if (totalRGB >= 100)
            {
                price = 14.99;
            }
            else
            {
                price = 10.99;
            }


            if (score == 9)
            {
                Debug.Log("GREAT JOB PERFECT - 9");
                balanceController.SellItem(price, 9);
            }
            else if (score == 8)
            {
                Debug.Log("Missed by a little - 8");
                balanceController.SellItem(price, 8);
            }
            else if (score == 7)
            {
                Debug.Log("Missed by a little - 7");
                balanceController.SellItem(price, 7);
            }
            else if (score == 6)
            {
                Debug.Log("Missed a bit - 6");
                balanceController.SellItem(price, 6);
            }
            else if (score == 5)
            {
                Debug.Log("Missed a bit - 5");
                balanceController.SellItem(price/1.05, 5);
            }
            else if (score == 4)
            {
                Debug.Log("Missed a good bit - 4");
                balanceController.SellItem(price/1.1, 4);
            }
            else if (score == 3)
            {
                Debug.Log("You missed a lot - 3");
                balanceController.SellItem(price/1.2, 3);
            }
            else if (score == 2)
            {
                Debug.Log("You missed a lot - 2");
                balanceController.SellItem(price/1.5, 2);
            }
            else if (score == 1)
            {
                Debug.Log("You barely even did anything - 1");
                balanceController.SellItem(price/1.75, 1);
            }
            else if (score == 0)
            {
                Debug.Log("What the hell did you do. - 0");
                balanceController.SellItem(price/2, 0);
            }
            StartCoroutine("DisplaySell");
            paintOrder.noOrder();
            inventoryManager.sellWhiteCan();
            paintcanAnimator.resetCan();
            paintCan.SetActive(false);
            paintCan = null;
        }
    }
}
