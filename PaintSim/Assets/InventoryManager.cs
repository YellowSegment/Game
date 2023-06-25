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
    public int maxRedTintCans;
    public int maxGreenTintCans;
    public int maxBlueTintCans;
    public int redTintCanTotal;
    public int greenTintCanTotal;
    public int blueTintCanTotal;
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
    public Text totalStirSticksText;
    public Text maxRedTint;
    public Text maxGreenTint;
    public Text maxBlueTint;
    public DayEndController dayEndController;

    public Text stockConfirm;
    public Text dayComing;
    public Text price;

    void Start()
    {
        this.paintCanTotal = whiteInventory;
        this.redTintCanTotal = redStock;
        this.greenTintCanTotal = greenStock;
        this.blueTintCanTotal = blueStock;
    }
    public void getInfo(int i)
    {
        dayComing.text = (dayEndController.getDayNumber()+1).ToString();
        if (i == 1)
        {
            price.text = "$" + 9.99;
            stockConfirm.text = (paintCanTotal + "/" + maxPaintCans).ToString();
        }
        else if (i == 2)
        {
            price.text = "$" + 2.99;
            stockConfirm.text = (totalStirSticks+dayEndController.getStirSticksAdded()).ToString();   
        }
        else if (i == 3)
        {
            price.text = "$" + 4.99;
            stockConfirm.text = redTintCanTotal + "/" + maxRedTintCans;
        }
        else if (i == 4)
        {
            price.text = "$" + 4.99;
            stockConfirm.text = greenTintCanTotal + "/" + maxGreenTintCans;
        }
        else if (i == 5)
        {
            price.text = "$" + 4.99;
            stockConfirm.text = blueTintCanTotal + "/" + maxBlueTintCans;
        }
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
        totalStirSticksText.text = totalStirSticks.ToString();
        maxRedTint.text = (maxRedTintCans*255).ToString();
        maxBlueTint.text = (maxBlueTintCans*255).ToString();
        maxGreenTint.text = (maxGreenTintCans*255).ToString();
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
            whiteInventory++;
    }

    public void addRedTint()
    {
            redStock++;
            totalRedTint += 255;
    }

    public int GetRedTintCanTotal()
    {
        return redTintCanTotal;
    }
    public int getMaxRedTintCans()
    {
        return maxRedTintCans;
    }
    public int getMaxGreenTintCans()
    {
        return maxGreenTintCans;
    }
    public int getMaxBlueTintCans()
    {
        return maxBlueTintCans;
    }
    public void addRedTintCanTotal()
    {
        redTintCanTotal++;
    }
    public int GetGreenTintCanTotal()
    {
        return greenTintCanTotal;
    }
    public void addGreenTintCanTotal()
    {
        greenTintCanTotal++;
    }
    public int GetBlueTintCanTotal()
    {
        return blueTintCanTotal;
    }
    public void addBlueTintCanTotal()
    {
        blueTintCanTotal++;
    }
    public void addGreenTint()
    {
            greenStock++;
            totalGreenTint += 255;
    }
    public void addBlueTint()
    {
            blueStock++;
            totalBlueTint += 255;
    }

    public void increasePaintCanStorage(int addedStorage)
    {
        maxPaintCans += addedStorage;
    }

    public void increaseTintStorage(int addedStorage)
    {
        maxRedTintCans += addedStorage;
        maxBlueTintCans += addedStorage;
        maxGreenTintCans += addedStorage;
    }

    public void sellWhiteCan()
    {
        whiteInventory--;
        paintCanTotal--;
    }

    public void addStirSticks()
    {
        totalStirSticks++;
    }

    public void removeRedTint(int tintUsed)
    {
        totalRedTint -= tintUsed;
        if (totalRedTint % 255 == 0)
        {
            redTintCanTotal--;
        }
    }
    public void removeBlueTint(int tintUsed)
    {
        totalBlueTint -= tintUsed;
        if (totalBlueTint % 255 == 0)
        {
            blueTintCanTotal--;
        }
    }
    public void removeGreenTint(int tintUsed)
    {
        totalGreenTint -= tintUsed;
        if (totalGreenTint % 255 == 0)
        {
            greenTintCanTotal--;
        }
    }
    public int getMaxPaintCans()
    {
        return maxPaintCans;
    }
    public void useStirStick()
    {
        totalStirSticks--;
    }
    public int getStirSticks()
    {
        return totalStirSticks;
    }
    public int getPaintCanTotal()
    {
        return paintCanTotal;
    }
    public void addPaintCans()
    {
        paintCanTotal++;
    }
    public void addRedTints()
    {
        redTintCanTotal++;
    }
    public void addGreenTints()
    {
        greenTintCanTotal++;
    }
    public void addBlueTints()
    {
        blueTintCanTotal++;
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
