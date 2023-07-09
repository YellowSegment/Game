using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BalanceController : MonoBehaviour
{

    public Text[] CurrencyUI; 
    private double money;
    public double tipLowerRange;
    public double tipHigherRange;
    public Text basePrice;
    public Text tipPrice;
    public Text qualityText;
    public Text totalPrice;
    public double balanceSent;
    public DayEndController dayEndController;


    // Start is called before the first frame update
    void Start()
    {
        tipLowerRange = 0;
        tipHigherRange = 3;
        setBalance(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem(double purchasePrice)
    {
        if (purchasePrice <= money && purchasePrice != -1)
        {
            money = Math.Round(money - purchasePrice, 2, MidpointRounding.AwayFromZero);
            UpdateBalanceUI();
        }
        else
        {
            Debug.Log("Not enough money to purchase item.");
            StartCoroutine(ShowNotEnoughMoneyMessage());
        }   
    }

   public void SellItem(double price, int quality)
    {
        double tipAmount = 0;
        switch (quality)
        {
            case 0:
                tipAmount = 0;
                qualityText.text = "AWFUL";
                break;
            case 1:
                tipAmount = UnityEngine.Random.Range(0f, (float)(tipHigherRange / 5));
                qualityText.text = "AWFUL";
                break;
            case 2:
                tipAmount = UnityEngine.Random.Range(0f, (float)(tipHigherRange / 3));
                qualityText.text = "AWFUL";
                break;
            case 3:
                tipAmount = UnityEngine.Random.Range(0f, (float)(tipHigherRange / 2));
                qualityText.text = "BAD";
                break;
            case 4:
                tipAmount = UnityEngine.Random.Range(0f, (float)(tipHigherRange / 1.5));
                qualityText.text = "BAD";
                break;
            case 5:
                tipAmount = UnityEngine.Random.Range(0f, (float)(tipHigherRange / 1.25));
                qualityText.text = "OKAY";
                break;
            case 6:
                tipAmount = UnityEngine.Random.Range((float)(tipLowerRange / 1.5), (float)(tipHigherRange / 1.1));
                qualityText.text = "OKAY";
                break;
            case 7:
                tipAmount = UnityEngine.Random.Range((float)(tipLowerRange / 1.1), (float)tipHigherRange);
                qualityText.text = "GOOD";
                break;
            case 8:
                tipAmount = UnityEngine.Random.Range((float)tipLowerRange, (float)tipHigherRange);
                qualityText.text = "GREAT";
                break;
            case 9:
                tipAmount = UnityEngine.Random.Range((float)(tipLowerRange + 0.5), (float)tipHigherRange);
                qualityText.text = "PERFECT";
                break;
        }
        basePrice.text = "$" + (Math.Round(price, 2, MidpointRounding.AwayFromZero)).ToString();
        tipPrice.text = "$" + (Math.Round(tipAmount, 2, MidpointRounding.AwayFromZero)).ToString();
        totalPrice.text = "$" + (Math.Round(price + tipAmount, 2, MidpointRounding.AwayFromZero)).ToString();
        balanceSent = Math.Round(price + tipAmount, 2, MidpointRounding.AwayFromZero);
        dayEndController.addMoney(balanceSent);
    }

    public void dayEndAddBalance(double balance)
    {
        money += balance;
        Debug.Log(balance);
        UpdateBalanceUI();
    }

    private void UpdateBalanceUI()
    {
        foreach (Text textElement in CurrencyUI)
        {
            textElement.text = "$" + money;
        }
    }

    public IEnumerator ShowNotEnoughMoneyMessage()
    {
        foreach (Text textElement in CurrencyUI)
        {
            textElement.text = "Not enough money!";
        }
        yield return new WaitForSeconds(2);
        UpdateBalanceUI();
    }

    public void setBalance(double balance)
    {
        money = balance;
        UpdateBalanceUI();
    }
    public double GetBalance()
    {
        return money;
    }

    public void tipRange(double percentIncrease, double lowerIncrease)
    {
        double HigherIncrease = Math.Round(tipHigherRange * (percentIncrease/100), 2, MidpointRounding.AwayFromZero);
        tipLowerRange += lowerIncrease;
        tipHigherRange += HigherIncrease;
        Debug.Log("Lower Range: " + tipLowerRange + " Higher Range: " + tipHigherRange);
    }

}
