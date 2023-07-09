using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject confirmPurchaseUI;
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
    private int item;
    public GameObject goggleUI;
    public int worldNumber = 1;
    GameObject[] objectsWithTag;
    public GameObject infoUI;
    public GameObject pauseUI;
    private bool pauseOpen;
    public Chair chair;
    public DecorToolController decorToolController;
    

    // Start is called before the first frame update
    void Start()
    {
        goggleUI.SetActive(true);
        balanceController = balanceControllerObject.GetComponent<BalanceController>();
        objectsWithTag = GameObject.FindGameObjectsWithTag("PaintCan");
        dayEndController = DayEndControllerObject.GetComponent<DayEndController>();
        infoUI.SetActive(true);
        pauseUI.SetActive(false);
        pauseOpen = false;

        foreach (GameObject obj in objectsWithTag)
        {
            paintCans.Add(obj);
            obj.GetComponent<PaintMixer>().resetPaint();
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
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseOpen && chair.isSitting() == false)
            {
                pauseUI.SetActive(true);
                pauseOpen = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && pauseOpen && chair.isSitting() == false)
            {
                pauseUI.SetActive(false);
                pauseOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
    }
    
    public void resume()
    {
        pauseUI.SetActive(false);
        pauseOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    public void buyNextWorld()
    {
        worldNumber++;
        inventoryManager.loadWorld(worldNumber);
    }
    public int getWorldNumber()
    {
        return worldNumber;
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
        confirmPurchaseUI.SetActive(false);
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
    public void addCans(int cansTotal)
    {
        for (int i = 0; i < cansTotal; i++)
        {
            paintCans[i].SetActive(true);
            paintCans[i].GetComponent<PaintCanAnimatorController>().setTotalTintsInCan(0,0,0);
        }
    }
    public void resetCans()
    {
        foreach (GameObject obj in objectsWithTag)
        {
            obj.SetActive(false);
        }
    }


    public void addConfirm()
    {
        if (item == 1)
        {
            buyWhiteBase();
            confirmPurchaseUI.SetActive(false);
        }
        else if (item == 2)
        {
            buyStirSticks();
            confirmPurchaseUI.SetActive(false);
        }
        else if (item == 3)
        {
            buyRedTint();
            confirmPurchaseUI.SetActive(false);
        }
        else if (item == 4)
        {
            buyGreenTint();
            confirmPurchaseUI.SetActive(false);
        }
        else if (item == 5)
        {
            buyBlueTint();
            confirmPurchaseUI.SetActive(false);
        }
    }

    public void itemClicked(int purchase)
    {
        confirmPurchaseUI.SetActive(true);
        inventoryManager.getInfo(purchase);
        item = purchase;
    }

    public void cancelConfirm()
    {
        confirmPurchaseUI.SetActive(false);
    }

    public void buyWhiteBase()
    {
        if (inventoryManager.getPaintCanTotal() < inventoryManager.getMaxPaintCans())
        {
            if (balanceController.GetBalance() >= 9.99)
            {
                dayEndController.SetPaintCan();
                balanceController.BuyItem(9.99);
                inventoryManager.addPaintCans();
            }
            else
            {
                balanceController.BuyItem(-1);
            }
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
