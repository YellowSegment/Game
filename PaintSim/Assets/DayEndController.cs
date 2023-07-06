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

    private float transitionSpeedNight = 0f;
private float transitionSpeedDay = 255f;
private float transitionDuration = 2f;
private float transitionTimer = 0f;
private bool isTransitioning = false;
private bool isTransitionComplete = false;

    public void endDayTransition()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            dayTransitionUI.SetActive(true);
            transitionTimer = 0f;
        }

        if (transitionTimer < transitionDuration)
        {
            transitionTimer += Time.deltaTime;
            float t = transitionTimer / transitionDuration;
            transitionSpeedNight = Mathf.Lerp(0f, 255f, t);
            dayTransitionUI.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)transitionSpeedNight);
        }
        else if (!isTransitionComplete)
        {
            isTransitionComplete = true;
            StartCoroutine(DelayedTransition());
        }
    }

    private IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(5f); // Delay for 2 seconds

        endDayTransitionDay();
        isTransitionComplete = false;
    }

    public void endDayTransitionDay()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            transitionTimer = 0f;
        }

        if (transitionTimer < transitionDuration)
        {
            transitionTimer += Time.deltaTime;
            float t = transitionTimer / transitionDuration;
            transitionSpeedDay = Mathf.Lerp(255f, 0f, t);
            dayTransitionUI.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)transitionSpeedDay);
        }
        else
        {
            isTransitioning = false;
            dayTransitionUI.SetActive(false);
            startTrans = false;
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
