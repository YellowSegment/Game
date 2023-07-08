using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameSaveLoadController : MonoBehaviour
{
    private int worldNumber;
    private double balance;
    private int paintCans;
    private int paintCansComing;
    private int redTintCans;
    private int redTintCansComing;
    private int redTintCansTotal;
    private int greenTintCans;
    private int greenTintCansComing;
    private int greenTintTotal;
    private int blueTintCans;
    private int blueTintCansComing;
    private int blueTintTotal;
    private int stirSticks;
    private int stirSticksComing;
    private int maxRedTintCans;
    private int maxGreenTintCans;
    private int maxBlueTintCans;
    private int paintCansTotal;
    private int[] tintAmount = new int[3];
    private int dayNumbers;
    private int paintOptions;
    private int timeOfDay;

    private int autoTinter;
    private int paintMixer;
    private int fan;
    private int counterTop;
    private int posters;
    private int workBench;

    public BalanceController balanceController;
    public InventoryManager inventoryManager;
    public ButtonUI buttonUI;
    public DayEndController dayEndController;
    public PaintOrder paintOrder;
    public DecorToolController decorToolController;

    void Start()
    {
        //Load();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            wipeData();
            Debug.Log("Successfully wiped data");
        }
    }
    public void Save()
    {
        worldNumber = buttonUI.getWorldNumber();
        balance = balanceController.GetBalance();

        paintCans = inventoryManager.getPaintCans();
        paintCansComing = dayEndController.getPaintCansAdded();
        paintCansTotal = inventoryManager.getPaintCanTotal();

        redTintCans = inventoryManager.getRedStock();
        redTintCansComing = dayEndController.getRedTintAdded();
        redTintCansTotal = inventoryManager.GetRedTintCanTotal();

        greenTintCans = inventoryManager.getGreenStock();
        greenTintCansComing = dayEndController.getGreenTintAdded();
        greenTintTotal = inventoryManager.GetGreenTintCanTotal();

        blueTintCans = inventoryManager.getBlueStock();
        blueTintCansComing = dayEndController.getBlueTintAdded();
        blueTintTotal = inventoryManager.GetBlueTintCanTotal();

        stirSticks = inventoryManager.getStirSticks();
        stirSticksComing = dayEndController.getStirSticksAdded();

        tintAmount[0] = inventoryManager.getRedTint();
        tintAmount[1] = inventoryManager.getGreenTint();
        tintAmount[2] = inventoryManager.getBlueTint();

        dayNumbers = dayEndController.getDayNumber();
        timeOfDay = dayEndController.getTime();

        paintOptions = paintOrder.GetPaintRange();

        autoTinter = decorToolController.getAutoTinter();
        paintMixer = decorToolController.getPaintMixer();
        fan = decorToolController.getFan();
        counterTop = decorToolController.getCounterTop();
        posters = decorToolController.getPosters();
        workBench = decorToolController.getWorkbench();

        Debug.Log("Game Successfully Saved");

        string destination = Application.persistentDataPath + "/save.dat";
        using (StreamWriter writer = new StreamWriter(destination))
        {
            writer.WriteLine(worldNumber);
            writer.WriteLine(balance);
            writer.WriteLine(paintCans);
            writer.WriteLine(paintCansComing);
            writer.WriteLine(paintCansTotal);
            writer.WriteLine(redTintCans);
            writer.WriteLine(redTintCansComing);
            writer.WriteLine(redTintCansTotal);
            writer.WriteLine(greenTintCans);
            writer.WriteLine(greenTintCansComing);
            writer.WriteLine(greenTintTotal);
            writer.WriteLine(blueTintCans);
            writer.WriteLine(blueTintCansComing);
            writer.WriteLine(blueTintTotal);
            writer.WriteLine(stirSticks);
            writer.WriteLine(stirSticksComing);
            writer.WriteLine(tintAmount[0]);
            writer.WriteLine(tintAmount[1]);
            writer.WriteLine(tintAmount[2]);
            writer.WriteLine(dayNumbers);
            writer.WriteLine(timeOfDay);
            writer.WriteLine(paintOptions);
            writer.WriteLine(autoTinter);
            writer.WriteLine(paintMixer);
            writer.WriteLine(fan);
            writer.WriteLine(counterTop);
            writer.WriteLine(posters);
            writer.WriteLine(workBench);
        }
    }
    public void Load()
    {
        string destination = Application.persistentDataPath + "/save.dat";

        if (File.Exists(destination))
        {
            using (StreamReader reader = new StreamReader(destination))
            {
                worldNumber = int.Parse(reader.ReadLine());
                balance = double.Parse(reader.ReadLine());
                paintCans = int.Parse(reader.ReadLine());
                paintCansComing = int.Parse(reader.ReadLine());
                paintCansTotal = int.Parse(reader.ReadLine());
                redTintCans = int.Parse(reader.ReadLine());
                redTintCansComing = int.Parse(reader.ReadLine());
                redTintCansTotal = int.Parse(reader.ReadLine());
                greenTintCans = int.Parse(reader.ReadLine());
                greenTintCansComing = int.Parse(reader.ReadLine());
                greenTintTotal = int.Parse(reader.ReadLine());
                blueTintCans = int.Parse(reader.ReadLine());
                blueTintCansComing = int.Parse(reader.ReadLine());
                blueTintTotal = int.Parse(reader.ReadLine());
                stirSticks = int.Parse(reader.ReadLine());
                stirSticksComing = int.Parse(reader.ReadLine());
                tintAmount[0] = int.Parse(reader.ReadLine());
                tintAmount[1] = int.Parse(reader.ReadLine());
                tintAmount[2] = int.Parse(reader.ReadLine());
                dayNumbers = int.Parse(reader.ReadLine());
                timeOfDay = int.Parse(reader.ReadLine());
                paintOptions = int.Parse(reader.ReadLine());
                autoTinter = int.Parse(reader.ReadLine());
                paintMixer = int.Parse(reader.ReadLine());
                fan = int.Parse(reader.ReadLine());
                counterTop = int.Parse(reader.ReadLine());
                posters = int.Parse(reader.ReadLine());
                workBench = int.Parse(reader.ReadLine());
            }

            inventoryManager.LoadData(worldNumber, paintCans, paintCansTotal, redTintCans, redTintCansTotal, greenTintCans, greenTintTotal, blueTintCans, blueTintTotal, stirSticks, tintAmount);
            balanceController.setBalance(balance);
            dayEndController.LoadData(paintCansComing, redTintCansComing, greenTintCansComing, blueTintCansComing, stirSticksComing, dayNumbers, timeOfDay);
            paintOrder.setPaintRange(paintOptions);
            buttonUI.resetCans();
            buttonUI.addCans(paintCans);
            decorToolController.LoadData(autoTinter, paintMixer, fan, counterTop, posters, workBench);

            Debug.Log("Game Successfully Loaded");
        }
        else
        {
            Debug.Log("No saved game found");
        }
    }

    public void wipeData()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        using (StreamWriter writer = new StreamWriter(destination))
        {
            writer.WriteLine(1);
            writer.WriteLine(20);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(730);
            writer.WriteLine(255);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            writer.WriteLine(0);
            }
    }
}