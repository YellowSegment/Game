using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int whiteInventory;
    public int midInventory;
    public int deepInventory;
    public int stickInventory;
    public int redStock;
    public int greenStock;
    public int blueStock;
    public int maxPaintCans;
    public int paintCanTotal;
    public int maxTintCans;
    public int tintCanTotal;
    public int totalStirSticks;
   

    void Start()
    {
        this.paintCanTotal = whiteInventory+midInventory+deepInventory;
        this.tintCanTotal = redStock+greenStock+blueStock;
    }

    void Update()
    {

    }

    public void addWhiteInventory()
    {
        if (paintCanTotal < maxPaintCans)
        {
            paintCanTotal++;
            whiteInventory++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }

    public void addMidInventory()
    {
        if (paintCanTotal < maxPaintCans)
        {
            paintCanTotal++;
            midInventory++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }
    
    public void addDeepInventory()
    {
        if (paintCanTotal < maxPaintCans)
        {
            paintCanTotal++;
            deepInventory++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }

    public void addRedTint()
    {
        if (tintCanTotal < maxTintCans)
        {
            redStock++;
            tintCanTotal++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }
    public void addGreenTint()
    {
        if (tintCanTotal < maxTintCans)
        {
            greenStock++;
            tintCanTotal++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }
    public void addBlueTint()
    {
        if (tintCanTotal < maxTintCans)
        {
            blueStock++;
            tintCanTotal++;
        }
        else
        {
            Debug.Log("Not enough storage");
        }
    }

    public void increasePaintCanStorage(int addedStorage)
    {
        maxPaintCans += addedStorage;
    }

    public void increaseTintStorage(int addedStorage)
    {
        maxTintCans += addedStorage;
    }

    public void sellWhiteCan()
    {
        whiteInventory--;
    }
    public void sellMidCan()
    {
        midInventory--;
    }
    public void sellDeepCan()
    {
        deepInventory--;
    }

    public void addStirSticks()
    {
        totalStirSticks+=10;
    }

}
