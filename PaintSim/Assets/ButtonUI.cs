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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void radiantClick()
    {
        desktopUi.SetActive(false);
        RadiantWeb.SetActive(true);
    }

    public void leaveRadiant()
    {
        RadiantWeb.SetActive(false);
        desktopUi.SetActive(true);
    }

    public void buyWhiteBase()
    {
        inventoryManager.addWhiteInventory();
    }
    public void buyMidBase()
    {
        inventoryManager.addMidInventory();
    }
    public void buyDeepBase()
    {
        inventoryManager.addDeepInventory();
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
}
