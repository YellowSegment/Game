using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaveLoadController : MonoBehaviour
{
    private int worldNumber;
    private double balance;
    private int paintCans;
    private int paintCansComing;
    private int redTintCans;
    private int redTintCansComing;
    private int redTintCansTotal;
    private int greenTintCans;
    private int greenTintCansComing;
    private int greenTintTotal;
    private int blueTintCans;
    private int blueTintCansComing;
    private int blueTintTotal;
    private int stirSticks;
    private int stirSticksComing;
    private int maxRedTintCans;
    private int maxGreenTintCans;
    private int maxBlueTintCans;
    private int paintCansTotal;
    private int[] tintAmount = new int[3];
    private int dayNumbers;
    private int paintOptions;
    private int timeOfDay;

    public BalanceController balanceController;
    public InventoryManager inventoryManager;
    public ButtonUI buttonUI;
    public DayEndController dayEndController;
    public PaintOrder paintOrder;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Load();
        }
    }
    public void Save()
    {
        worldNumber = buttonUI.getWorldNumber();
        balance = balanceController.GetBalance();

        paintCans = inventoryManager.getPaintCans();
        paintCansComing = dayEndController.getPaintCansAdded();
        paintCansTotal = inventoryManager.getPaintCanTotal();

        redTintCans = inventoryManager.getRedStock();
        redTintCansComing = dayEndController.getRedTintAdded();
        redTintCansTotal = inventoryManager.GetRedTintCanTotal();

        greenTintCans = inventoryManager.getGreenStock();
        greenTintCansComing = dayEndController.getGreenTintAdded();
        greenTintTotal = inventoryManager.GetGreenTintCanTotal();

        blueTintCans = inventoryManager.getBlueStock();
        blueTintCansComing = dayEndController.getBlueTintAdded();
        blueTintTotal = inventoryManager.GetBlueTintCanTotal();

        stirSticks = inventoryManager.getStirSticks();
        stirSticksComing = dayEndController.getStirSticksAdded();

        tintAmount[0] = inventoryManager.getRedTint();
        tintAmount[1] = inventoryManager.getGreenTint();
        tintAmount[2] = inventoryManager.getBlueTint();

        dayNumbers = dayEndController.getDayNumber();
        timeOfDay = dayEndController.getTime();

        paintOptions = paintOrder.GetPaintRange();

        Debug.Log("Game Successfully Saved");
    }
    public void Load()
    {
        inventoryManager.LoadData(worldNumber, paintCans, paintCansTotal, redTintCans, redTintCansTotal, greenTintCans, greenTintTotal, blueTintCans, blueTintTotal, stirSticks, tintAmount);
        balanceController.setBalance(balance);
        dayEndController.LoadData(paintCansComing, redTintCansComing, greenTintCansComing, blueTintCansComing, stirSticksComing, dayNumbers, timeOfDay);
        paintOrder.setPaintRange(paintOptions);
        buttonUI.resetCans();
        buttonUI.addCans(paintCans);
        
        Debug.Log("Game Successfully Loaded");
    }    
}
