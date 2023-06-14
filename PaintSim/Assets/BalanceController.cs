using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BalanceController : MonoBehaviour
{

    public Text CurrencyUI; 
    private double money;
    public double tipLowerRange;
    public double tipHigherRange;


    // Start is called before the first frame update
    void Start()
    {
        tipLowerRange = 0;
        tipHigherRange = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            BuyItem(3.99);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            SellItem(3.89, 9);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            tipRange(10);
        }
    }

    public void BuyItem(double purchasePrice)
    {
        if (purchasePrice <= money)
        {
            money = Math.Round(money - purchasePrice, 2, MidpointRounding.AwayFromZero);
            CurrencyUI.text = "$" + money;
        }
        else
        {
            Debug.Log("Not enough money to purchase item.");
            StartCoroutine(ShowNotEnoughMoneyMessage());
        }   
    }

    public void SellItem(double price, int quality)
    {
        money = Math.Round(money + price, 2, MidpointRounding.AwayFromZero);
        CurrencyUI.text = "$" + money;
    }

    public IEnumerator ShowNotEnoughMoneyMessage()
    {
        CurrencyUI.text = "Not enough money!";
        yield return new WaitForSeconds(2);
        CurrencyUI.text = "$" + money;
    }

    public void getBalance(double balance)
    {
        money = balance;
    }

    public void tipRange(double percentIncrease)
    {
        double HigherIncrease = tipHigherRange * (percentIncrease/100);
        tipLowerRange += .25;
        tipHigherRange += HigherIncrease;
        Debug.Log("Lower Range: " + tipLowerRange + " Higher Range: " + tipHigherRange);
    }

}
