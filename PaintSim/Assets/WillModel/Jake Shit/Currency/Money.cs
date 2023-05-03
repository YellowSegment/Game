using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public double money;
    public Text CurrencyUI;
    // Start is called before the first frame update
    void Start()
    {
        money = 20.00;
        CurrencyUI.text = "$" + money;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PurchaseItem(double purchasePrice)
    {
        if (purchasePrice <= money)
        {
            money = Math.Round(money - purchasePrice, 2, MidpointRounding.AwayFromZero);
            Debug.Log("Item purchased for " + purchasePrice + ", new balance: " + money);
            CurrencyUI.text = "$" + money;
        }
        else
        {
            Debug.Log("Not enough money to purchase item.");
        }   
    }

    public void SellItem(double sellPrice)
    {
        money = Math.Round(money + sellPrice, 2, MidpointRounding.AwayFromZero);
        Debug.Log("Item sold for " + sellPrice + ", new balance: " + money);
        CurrencyUI.text = "$" + money;
    }

}
