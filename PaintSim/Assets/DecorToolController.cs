using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecorToolController : MonoBehaviour
{
    List<GameObject> autoTinters = new List<GameObject>();
    GameObject[] autoTinterTags;
    List<GameObject> paintMixers = new List<GameObject>();
    GameObject[] paintMixerTags;
    List<GameObject> fans = new List<GameObject>();
    GameObject[] fanTags;
    List<GameObject> postersList = new List<GameObject>();
    GameObject[] posterTags; 
    List<GameObject> workBenches = new List<GameObject>();
    GameObject[] workBenchTags;
    List<GameObject> counterTopSigns = new List<GameObject>();
    GameObject[] counterTopSignTags;

    private int autoTinter;
    private int paintMixer;
    private int fan;
    private int counterTop;
    private int posters;
    private int workBench;
    private int item;

    public Text dayComingText;
    public Text price;
    public Text stockAmount;

    public GameObject confirmPurchaseUI;
    public BalanceController balanceController;
    public DayEndController dayEndController;
    public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        autoTinterTags = GameObject.FindGameObjectsWithTag("AutoTinter");
        paintMixerTags = GameObject.FindGameObjectsWithTag("PaintMixer");
        fanTags = GameObject.FindGameObjectsWithTag("Fan");
        posterTags = GameObject.FindGameObjectsWithTag("Posters");
        workBenchTags = GameObject.FindGameObjectsWithTag("Workbenches");
        counterTopSignTags = GameObject.FindGameObjectsWithTag("CounterSign");

        foreach (GameObject obj in autoTinterTags)
        {
            autoTinters.Add(obj);
            obj.SetActive(false);
        }
        foreach (GameObject obj in paintMixerTags)
        {
            paintMixers.Add(obj);
            obj.SetActive(false);
        }
        foreach (GameObject obj in fanTags)
        {
            fans.Add(obj);
            obj.SetActive(false);
        }
        foreach (GameObject obj in posterTags)
        {
            postersList.Add(obj);
            obj.SetActive(false);
        }
        foreach (GameObject obj in workBenchTags)
        {
            workBenches.Add(obj);
            obj.SetActive(false);
        }
        foreach (GameObject obj in counterTopSignTags)
        {
            counterTopSigns.Add(obj);
            obj.SetActive(false);
        }
        workBenches[workBench].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void itemClicked(int purchase)
    {
        confirmPurchaseUI.SetActive(true);
        item = purchase;
        getConfirmation(item);
    }

    public void getConfirmation(int itemNumber)
    {
        if (itemNumber == 1)
        {
            dayComingText.text = (dayEndController.getDayNumber()+2).ToString();
            price.text = "$850.00";
            stockAmount.text = paintMixer + "/" + paintMixers.Count;
        }
        else if (itemNumber == 2)
        {
            dayComingText.text = (dayEndController.getDayNumber()+2).ToString();
            price.text = "$1500.00";
            stockAmount.text = autoTinter + "/" + autoTinters.Count;
        }
        else if (itemNumber == 3)
        {
            dayComingText.text = (dayEndController.getDayNumber()+1).ToString();
            price.text = "$20.00";
            stockAmount.text = counterTop + "/" + counterTopSigns.Count;
        }
    }

    public void confirmedPurchase()
    {
        if (item == 1)
        {
            buyPaintMixer();
        }
        else if (item == 2)
        {
            buyAutoTinter();
        }
        else if (item == 3)
        {
            buyCounterSign();
        }
        confirmPurchaseUI.SetActive(false);
    }

    public void cancelConfirm()
    {
        confirmPurchaseUI.SetActive(false);
    }

    public void buyAutoTinter()
    {
        if (balanceController.GetBalance() >= 1500)
            if (autoTinter < autoTinters.Count)
            {
                balanceController.BuyItem(1500);
                autoTinters[autoTinter].SetActive(true);
                autoTinter++;
            }
            else
            {
                Debug.Log("NO ROOM");
            }
        else
        {
            balanceController.BuyItem(-1);
        }
    }
    public void buyPaintMixer()
    {
        if (balanceController.GetBalance() >= 850)
        {
            if (paintMixer < paintMixers.Count)
            {
                balanceController.BuyItem(1500);
                paintMixers[paintMixer].SetActive(true);
                paintMixer++;
            }
            else
            {
                Debug.Log("NO ROOM");
            }
        }
        else
        {
            balanceController.BuyItem(-1);
        }
        
    }
    public void buyFan()
    {
        if (fan < fans.Count)
        {
            fans[fan].SetActive(true);
            fan++;
        }
        else
        {
            Debug.Log("NO ROOM");
        }
    }
    public void buyCounterSign()
    {
        if (balanceController.GetBalance() >= 20)
        {
            if (counterTop < counterTopSigns.Count)
            {
                balanceController.BuyItem(20);
                counterTopSigns[counterTop].SetActive(true);
                counterTop++;
            }
            else
            {
                Debug.Log("NO ROOM");
            }
        }
        else
        {
            balanceController.BuyItem(-1);
        }
        
    }
    public void buyPosters()
    {
        if (posters < postersList.Count)
        {
            postersList[posters].SetActive(true);
            posters++;
        }
    }
    public void upgradeWorkbench()
    {
        if (workBench + 1 < workBenches.Count)
        {
            workBenches[workBench].SetActive(false);
            workBench++;
            workBenches[workBench].SetActive(true);
        }
        else
        {
            Debug.Log("Oh. there is not any more upgrades");
        }
    }

    public int getAutoTinter()
    {
        return autoTinter;
    }
    public int getPaintMixer()
    {
        return paintMixer;
    }
    public int getFan()
    {
        return fan;
    }
    public int getCounterTop()
    {
        return counterTop;
    }
    public int getPosters()
    {
        return posters;
    }
    public int getWorkbench()
    {
        return workBench;
    }

    public void LoadData(int autoTinter, int paintMixer, int fan, int counterTop, int posters, int workBench)
    {
        this.autoTinter = autoTinter;
        this.paintMixer = paintMixer;
        this.fan = fan;
        this.counterTop = counterTop;
        this.posters = posters;
        this.workBench = workBench;
        setObjects();
    }

    public void setObjects()
    {
        for (int i = 0; i < autoTinter; i++)
        {
            autoTinters[i].SetActive(true);
        }
        for (int i = 0; i < paintMixer; i++)
        {
            paintMixers[i].SetActive(true);
        }
        for (int i = 0; i < fan; i++)
        {
            fans[i].SetActive(true);
        }
        for (int i = 0; i < counterTop; i++)
        {
            counterTopSigns[i].SetActive(true);
        }
        for (int i = 0; i < posters; i++)
        {
            postersList[i].SetActive(true);
        }
        workBenches[0].SetActive(false);
        workBenches[workBench].SetActive(true);
    }
}
