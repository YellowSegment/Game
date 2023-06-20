using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayEndController : MonoBehaviour
{

    public int paintCansAdded;
    public int redTintAdded;
    public int greenTintAdded;
    public int blueTintAdded;
    public int stirSticksAdded;
    public GameObject ButtonControllerObject;
    private ButtonUI buttonUI;
    public Text paintStockUI;
    public InventoryManager inventoryManager;
    public int dayNumber;
    public Text dayNumberUI;

    void Start()
    {
        buttonUI = ButtonControllerObject.GetComponent<ButtonUI>();
        paintStockUI.text = "+" + paintCansAdded;
    }
    void Update()
    {
        paintStockUI.text = "+" + paintCansAdded;
        if (Input.GetKeyDown(KeyCode.K))
        {
            endOfDay();
        }
        dayNumberUI.text = ""+dayNumber;
    }

    public void SetPaintCan()
    {
        paintCansAdded++;
    }
    public void SetRedTintAdded()
    {
        redTintAdded++;
    }
    public void SetGreenTintAdded()
    {
        greenTintAdded++;
    }
    public void SetBlueTintAdded()
    {
        blueTintAdded++;
    }
    public void setStirSticksAdded()
    {
        stirSticksAdded++;
    }
    public int getPaintCansAdded()
    {
        return paintCansAdded;
    }
    public int getRedTintAdded()
    {
        return redTintAdded;
    }
    public int getGreenTintAdded()
    {
        return greenTintAdded;
    }
    public int getBlueTintAdded()
    {
        return blueTintAdded;
    }
    public int getStirSticksAdded()
    {
        return stirSticksAdded;
    }

    public void endOfDay()
    {
        dayNumber++;
        for (int i = 0; i < paintCansAdded; i++)
        {
            buttonUI.addCan();
            inventoryManager.addWhiteInventory();
        }

        paintCansAdded = 0;
        redTintAdded = 0;
        greenTintAdded = 0;
        blueTintAdded = 0;
        stirSticksAdded = 0;
    }
}
