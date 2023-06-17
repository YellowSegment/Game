using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public int whiteInventory;
    public int stickInventory;
    public int redStock;
    public int greenStock;
    public int blueStock;
    public int maxPaintCans;
    public int paintCanTotal;
    public int maxTintCans;
    public int tintCanTotal;
    public int totalStirSticks;
    public int totalRedTint;
    public int totalGreenTint;
    public int totalBlueTint;
    public Text redAmount1;
    public Text redAmount2;
    public Text greenAmount1;
    public Text greenAmount2;
    public Text blueAmount1;
    public Text blueAmount2;
    public Text paintCanAmount;

    void Start()
    {
        this.paintCanTotal = whiteInventory;
        this.tintCanTotal = redStock+greenStock+blueStock;
    }

    void Update()
    {
        if (getRedTint() > 999)
        {
            redAmount2.text = "+999";
        }
        else
        {
            redAmount2.text = getRedTint().ToString();
        }
        redAmount1.text = getRedTint().ToString();
        greenAmount1.text = getGreenTint().ToString();
        blueAmount1.text = getBlueTint().ToString();
        paintCanAmount.text = paintCanTotal.ToString();
        if (getGreenTint() > 999)
        {
            greenAmount2.text = "+999";
        }
        else
        {
           greenAmount2.text = getGreenTint().ToString(); 
        }
        if (getBlueTint() > 999)
        {
            greenAmount2.text = "+999";
        }
        else
        {
            blueAmount2.text = getBlueTint().ToString();
        }
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

    public void addRedTint()
    {
        if (tintCanTotal < maxTintCans)
        {
            redStock++;
            tintCanTotal++;
            totalRedTint += 255;
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
            totalGreenTint += 255;
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
            totalBlueTint += 255;
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
        paintCanTotal--;
    }

    public void addStirSticks()
    {
        totalStirSticks+=10;
    }

    public void removeRedTint(int tintUsed)
    {
        totalRedTint -= tintUsed;
        if (totalRedTint % 255 == 0)
        {
            tintCanTotal--;
        }
    }
    public void removeBlueTint(int tintUsed)
    {
        totalBlueTint -= tintUsed;
        if (totalBlueTint % 255 == 0)
        {
            tintCanTotal--;
        }
    }
    public void removeGreenTint(int tintUsed)
    {
        totalGreenTint -= tintUsed;
        if (totalGreenTint % 255 == 0)
        {
            tintCanTotal--;
        }
    }

    public int getRedTint()
    {
        return totalRedTint;
    }
    public int getGreenTint()
    {
        return totalGreenTint;
    }
    public int getBlueTint()
    {
        return totalBlueTint;
    }

}
