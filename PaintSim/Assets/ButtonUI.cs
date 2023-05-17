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
}
