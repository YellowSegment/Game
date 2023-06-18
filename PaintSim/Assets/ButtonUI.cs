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
    List<GameObject> paintCans = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        balanceController = balanceControllerObject.GetComponent<BalanceController>();
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("PaintCan");
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
            inventoryManager.addWhiteInventory();
            addCan();
            balanceController.BuyItem(9.99);
        }
        else
        {
            balanceController.BuyItem(-1);
        }
        
    }

    public void buyStirSticks()
    {
        inventoryManager.addStirSticks();
    }
    public void buyRedTint()
    {
        inventoryManager.addRedTint();
    }
    public void buyGreenTint()
    {
        inventoryManager.addGreenTint();
    }
    public void buyBlueTint()
    {
        inventoryManager.addBlueTint();
    }

    public bool getOnSite()
    {
        return onWebsite;
    }
}
