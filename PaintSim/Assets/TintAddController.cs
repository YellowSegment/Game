using UnityEngine;

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


    void Start()
    {
        tintChoiceController = tintChoiceObject.GetComponent<TintChoiceController>();
        inventoryManager = inventoryManagerObject.GetComponent<InventoryManager>();
        paintCanPlaceScript = paintCanPlaceObject.GetComponent<PaintCanPlace>(); // Assign the reference here
    }

    void Update()
    {
            if (Input.GetMouseButton(1))
            {
                if (!tintChoiceController.GetIsFastPour())
                {
                    timer += Time.deltaTime; // Increment the timer with the elapsed time
                    if (timer >= pourRateSlow)
                    {
                        if (tintChoiceController.GetIsRed() && inventoryManager.getRedTint() > totalRedTint)
                        {
                            totalRedTint++; // Increment totalRedTint by 1
                            timer = 0f; // Reset the timer
                        }
                        else if (tintChoiceController.GetIsBlue() && inventoryManager.getBlueTint() > totalBlueTint)
                        {
                            totalBlueTint++;
                            timer = 0f;
                        }
                        else if (tintChoiceController.GetIsGreen() && inventoryManager.getGreenTint() > totalGreenTint)
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
                        if (tintChoiceController.GetIsRed())
                        {
                            if (inventoryManager.getRedTint() > totalRedTint)
                            {
                                totalRedTint++; // Increment totalRedTint by 1
                                timer = 0f; // Reset the timer
                            }
                            else
                            {

                            }
                        }
                        else if (tintChoiceController.GetIsBlue())
                        {
                            if (inventoryManager.getBlueTint() > totalBlueTint)
                            {
                                totalBlueTint++;
                                timer = 0f;
                            }
                            else
                            {

                            }
                        }
                        else if (tintChoiceController.GetIsGreen())
                        {
                            if (inventoryManager.getGreenTint() > totalGreenTint)
                            {
                                totalGreenTint++;
                                timer = 0f;
                                Debug.Log(inventoryManager.getGreenTint());
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }
}
