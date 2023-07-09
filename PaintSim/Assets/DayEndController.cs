using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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
    public Text redTintComing;
    public Text greenTintComing;
    public Text blueTintComing;
    public Text stirSticksComing;
    public Text timeText;
    public GameObject sun;
    private Light sunLight;
    Color daylight = Color.white;
    Color nightTime = Color.black;
    float daySpeed = 250f;
    public GameObject dayTransitionUI;
    public BalanceController balanceController;

    public int time;
    public float totalTime;
    public float timePassed;
    public int hour;
    public int minute;
    public float timerSpeed;
    public float t;
    private bool goingUp;
    private bool startTrans;
    private bool isDone;
    private bool startDay;
    private int dayStartTime;
    private double heldBalance;
    public Text heldBalanceText;


    void Start()
    {
        buttonUI = ButtonControllerObject.GetComponent<ButtonUI>();
        paintStockUI.text = "+" + paintCansAdded;
        timerSpeed = 2.5f;
        hour = 7;
        totalTime = 30;
        sunLight = sun.GetComponent<Light>();
        dayTransitionUI.SetActive(false);

    }
    void Update()
    {
        paintStockUI.text = "+" + (paintCansAdded);
        redTintComing.text = "+" + (redTintAdded * 255);
        greenTintComing.text = "+" + (greenTintAdded * 255);
        blueTintComing.text = "+" + (blueTintAdded * 255);
        stirSticksComing.text = "+" + stirSticksAdded;
        if (Input.GetKeyDown(KeyCode.K))
        {
            endOfDay();
        }
        dayNumberUI.text = ""+dayNumber;

        totalTime += Time.deltaTime*timerSpeed;
        if (totalTime >= 60)
        {
            totalTime = 0;
            hour++;
            minute = 0;
        }
        if (hour == 24)
        {
            hour = 0;
            endOfDay();
        }
        minute = (int)totalTime;

        string formattedHour = hour.ToString("00");
        string formattedMinute = minute.ToString("00");
        timeText.text = formattedHour + ":" + formattedMinute;

        if (goingUp)
        {
            t += Time.deltaTime / daySpeed;

            if (t >= 1)
            {
                t = 1;
                goingUp = false;
            }
        }
        else
        {
            t -= Time.deltaTime / daySpeed;

            if (t <= 0)
            {
                t = 0;
                goingUp = true;
            }
        }
        if (startTrans == true && !isDone)
        {
            endDayTransition();
        }
        sunLight.color = Color.Lerp(daylight, nightTime, t);


        if (startTrans == true)
        {
            pauseTime();
            endDayTransition();
        }
        if (transition == true)
        {
            pauseTime();
        }
        if (transition == true && Input.GetMouseButtonDown(0))
        {
            startDay = true;
            dayStartTime = 510;
        }
        if (startDay == true)
        {
            pauseTime();
            transition = false;
            endDayTransitionDay();
        }
    }

    public void setTime(int time)
    {
        if (time >= 60)
        {
            hour = time / 100;
        }
        minute = time % 100;
        totalTime = minute;
    }

    public int getTime()
    {
        time = (hour * 100) + minute;
        return time;
    }

    public void pauseTime()
    {
        setTime(0730);
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
        stirSticksAdded += 3;
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
    public int getDayNumber()
    {
        return dayNumber;
    }
    public void LoadData(int paintCansComing, int redTintCansComing, int greenTintCansComing, int blueTintCansComing, int stirSticksComing, int dayNumber, int timeOfDay)
    {
        paintCansAdded = paintCansComing;
        redTintAdded = redTintCansComing;
        greenTintAdded = greenTintCansComing;
        blueTintAdded = blueTintCansComing; 
        stirSticksAdded = stirSticksComing;
        this.dayNumber = dayNumber;
        setTime(timeOfDay);
    }

    public void addMoney(double balance)
    {
        heldBalance += balance;
        heldBalanceText.text = "$" + heldBalance.ToString();
    }

    private float transitionTimer = 0f;
    private bool transition;

    public void endDayTransition()
    {
        dayTransitionUI.SetActive(true);
        if (transitionTimer < 510)
        {
            transitionTimer++;
            dayTransitionUI.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)(transitionTimer/2));
        }
        if (transitionTimer >= 510)
        {
            startTrans = false;
            transition = true;
        }
    }



    public void endDayTransitionDay()
    {
        if (dayStartTime > 0)
        {
            dayStartTime--;
            dayTransitionUI.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)(dayStartTime/2));
        }
        if (dayStartTime <= 0)
        {
            startTrans = false;
            transition = false;
            startDay = false;
            Debug.Log("Transition Complete");
        }
    }




    public void endOfDay()
    {
        startTrans = true;
        dayNumber++;
        hour = 7;
        minute = 30;
        totalTime = minute;
        sunLight.color = Color.white;
        balanceController.dayEndAddBalance(heldBalance);
        heldBalance = 0;
        t = 0;
        for (int i = 0; i < paintCansAdded; i++)
        {
            buttonUI.addCan();
            inventoryManager.addWhiteInventory();
        }
        for (int i = 0; i < stirSticksAdded; i++)
        {
            inventoryManager.addStirSticks();
        }
        for (int i = 0; i < redTintAdded; i++)
        {
            inventoryManager.addRedTint();
        }
        for (int i = 0; i < greenTintAdded; i++)
        {
            inventoryManager.addGreenTint();
        }
        for (int i = 0; i < blueTintAdded; i++)
        {
            inventoryManager.addBlueTint();
        }

        paintCansAdded = 0;
        redTintAdded = 0;
        greenTintAdded = 0;
        blueTintAdded = 0;
        stirSticksAdded = 0;
    }
}
