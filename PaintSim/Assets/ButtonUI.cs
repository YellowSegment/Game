using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject RadiantWeb;
    public GameObject desktopUi;
    public GameObject FauxPropertiesWeb;
    public GameObject PigmentPeddlerWeb;
    public GameObject DoodadEmporiumWeb;
    public GameObject InaccuSmartWeb;
    public InventoryManager inventoryManager;
    private bool onWebsite;
    public GameObject balanceControllerObject;
    private BalanceController balanceController;
    public GameObject DayEndControllerObject;
    private DayEndController dayEndController;
    List<GameObject> paintCans = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        balanceController = balanceControllerObject.GetComponent<BalanceController>();
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("PaintCan");
        dayEndController = DayEndControllerObject.GetComponent<DayEndController>();
        foreach (GameObject obj in objectsWithTag)
        {
            paintCans.Add(obj);
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (onWebsite && Input.GetKeyDown(KeyCode.Escape))
        {
            desktopUi.SetActive(true);
            RadiantWeb.SetActive(false);
            DoodadEmporiumWeb.SetActive(false);
            FauxPropertiesWeb.SetActive(false);
            PigmentPeddlerWeb.SetActive(false);
            InaccuSmartWeb.SetActive(false);
            onWebsite = false;
        }
    }

    public void inAccusmartClick()
    {
        desktopUi.SetActive(false);
        InaccuSmartWeb.SetActive(true);
        onWebsite = true;
    }
    public void leaveinAccusmart()
    {
        InaccuSmartWeb.SetActive(false);
        desktopUi.SetActive(true);
        onWebsite = false;
    }

    public void radiantClick()
    {
        desktopUi.SetActive(false);
        RadiantWeb.SetActive(true);
        onWebsite = true;
    }

    public void leaveRadiant()
    {
        RadiantWeb.SetActive(false);
        desktopUi.SetActive(true);
        onWebsite = false;
    }

    public void leaveDooDad()
    {
        DoodadEmporiumWeb.SetActive(false);
        desktopUi.SetActive(true);
        onWebsite = false;
    }
    public void doodadClick()
    {
        desktopUi.SetActive(false);
        DoodadEmporiumWeb.SetActive(true);
        onWebsite = true;
    }

    public void addCan()
    {
        for (int i = 0; i < paintCans.Count; i++)
        {
            if (!paintCans[i].activeSelf)
            {
                paintCans[i].SetActive(true);
                paintCans[i].GetComponent<PaintCanAnimatorController>().setTotalTintsInCan(0,0,0);
                break;
            }
        }
    }

    public void buyWhiteBase()
    {
        if (balanceController.GetBalance() >= 9.99)
        {
            dayEndController.SetPaintCan();
            balanceController.BuyItem(9.99);
        }
        else
        {
            balanceController.BuyItem(-1);
        }
        
    }

    public void buyStirSticks()
    {
        if (balanceController.GetBalance() >= 2.99)
        {
            dayEndController.setStirSticksAdded();
            balanceController.BuyItem(2.99);
        }
        else
        {
            balanceController.BuyItem(-1);
        }
    }
    public void buyRedTint()
    {
        if (balanceController.GetBalance() >= 4.99)
        {
        if (inventoryManager.GetRedTintCanTotal() < inventoryManager.getMaxRedTintCans())
            {
            inventoryManager.addRedTintCanTotal();
            dayEndController.SetRedTintAdded();
            balanceController.BuyItem(4.99);
            }
            else
            {
                Debug.Log("Not enough storage");
            }
        }
        else
        {
            balanceController.BuyItem(-1);
        }
    }
    public void buyGreenTint()
    {
        if (balanceController.GetBalance() >= 4.99)
        {
            if(inventoryManager.GetGreenTintCanTotal() < inventoryManager.getMaxGreenTintCans())
            {
            inventoryManager.addGreenTintCanTotal();
            dayEndController.SetGreenTintAdded();
            balanceController.BuyItem(4.99);
            }
            else
            {
                Debug.Log("Not enough storage");
            }
        }
        else
        {
            balanceController.BuyItem(-1);
        }
    }
    public void buyBlueTint()
    {
        if (balanceController.GetBalance() >= 4.99)
        {
            if(inventoryManager.GetBlueTintCanTotal() < inventoryManager.getMaxBlueTintCans())
            {
                inventoryManager.addBlueTintCanTotal();
                dayEndController.SetBlueTintAdded();
                balanceController.BuyItem(4.99);
            }
            else
            {
                Debug.Log("Not enough storage");
            }
        }
        else
        {
            balanceController.BuyItem(-1);
        }
    }

    public bool getOnSite()
    {
        return onWebsite;
    }
}
