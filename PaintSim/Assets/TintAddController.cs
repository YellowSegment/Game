using UnityEngine;
using UnityEngine.UI;

public class TintAddController : MonoBehaviour
{
    public float pourRateFast;
    public float pourRateSlow;
    public int totalRedTint;
    public int totalGreenTint;
    public int totalBlueTint;
    public bool slowPour;
    private TintChoiceController tintChoiceController;
    private InventoryManager inventoryManager;
    public GameObject tintChoiceObject;
    public GameObject inventoryManagerObject;
    private float timer;
    public GameObject paintCanPlaceObject;
    private PaintCanPlace paintCanPlaceScript;
    public bool canIsOpen;
    public Text totalRedAdded;
    public Text totalBlueAdded;
    public Text totalGreenAdded;
    private int count;
    private GameObject paintCanTinting;
    public bool gotPaintCan;
    private PaintCanAnimatorController paintCanAnimatorController;

    void Start()
    {
        count = 0;
        tintChoiceController = tintChoiceObject.GetComponent<TintChoiceController>();
        inventoryManager = inventoryManagerObject.GetComponent<InventoryManager>();
        paintCanPlaceScript = paintCanPlaceObject.GetComponent<PaintCanPlace>(); // Assign the reference here
        canIsOpen = false;
        paintCanAnimatorController = null;
    }

    void Update()
    {
        totalRedAdded.text = totalRedTint.ToString();
        totalBlueAdded.text = totalBlueTint.ToString();
        totalGreenAdded.text = totalGreenTint.ToString();
        if (count == 0 && paintCanPlaceScript.GetIsPaintPlaced())
        {
            paintCanTinting = paintCanPlaceScript.getPaintCan();
            paintCanAnimatorController = paintCanTinting.GetComponent<PaintCanAnimatorController>();
            gotPaintCan = true;
            count++;
            totalRedTint = paintCanAnimatorController.getTotalRedTintInCan();
            totalGreenTint = paintCanAnimatorController.getTotalGreenTintInCan();
            totalBlueTint = paintCanAnimatorController.getTotalBlueTintInCan();
        }
        if(paintCanPlaceScript.GetIsPaintPlaced())
        {
            if(Input.GetMouseButtonDown(1))
            {
                if (canIsOpen)
                {
                    canIsOpen = false;
                    Debug.Log("Can is not open");
                }
                else if (!canIsOpen)
                {
                    canIsOpen = true;
                    Debug.Log("Can is open");
                }
            }
        }
        if (!canIsOpen && gotPaintCan && Input.GetKeyDown(KeyCode.F))
        {
            paintCanAnimatorController.setTotalTintsInCan(totalRedTint, totalGreenTint, totalBlueTint);
            count = 0;
            gotPaintCan = false;
        }
        if(paintCanPlaceScript.GetIsPaintPlaced() && canIsOpen)
        {
            if (Input.GetMouseButton(0))
            {
                if (!tintChoiceController.GetIsFastPour())
                {
                    timer += Time.deltaTime; // Increment the timer with the elapsed time
                    if (timer >= pourRateSlow)
                    {
                        if (tintChoiceController.GetIsRed() && inventoryManager.getRedTint() > totalRedTint && totalRedTint <= 255)
                        {
                            totalRedTint++; // Increment totalRedTint by 1
                            timer = 0f; // Reset the timer
                        }
                        else if (tintChoiceController.GetIsBlue() && inventoryManager.getBlueTint() > totalBlueTint && totalBlueTint <= 255)
                        {
                            totalBlueTint++;
                            timer = 0f;
                        }
                        else if (tintChoiceController.GetIsGreen() && inventoryManager.getGreenTint() > totalGreenTint && totalGreenTint <= 255)
                        {
                            totalGreenTint++;
                            timer = 0f;
                        }
                    }
                }
                else
                {
                    timer += Time.deltaTime;
                    if (timer >= pourRateFast)
                    {
                        if (tintChoiceController.GetIsRed() && inventoryManager.getRedTint() > totalRedTint && totalRedTint <= 255)
                        {
                            totalRedTint++; // Increment totalRedTint by 1
                            timer = 0f; // Reset the timer
                        }
                        else if (tintChoiceController.GetIsBlue() && inventoryManager.getBlueTint() > totalBlueTint && totalBlueTint <= 255)
                        {
                            totalBlueTint++;
                            timer = 0f;
                        }
                        else if (tintChoiceController.GetIsGreen() && inventoryManager.getGreenTint() > totalGreenTint && totalGreenTint <= 255)
                        {
                            totalGreenTint++;
                            timer = 0f;
                        }
                    }
                }
            }
        }
    }
}
