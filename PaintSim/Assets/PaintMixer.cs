using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintMixer : MonoBehaviour
{
    public Material paintMaterial;
    public GameObject PaintCanPlaceObject;
    private PaintCanPlace paintCanPlaceScript;
    // Start is called before the first frame update
    private GameObject paintCanMaterial;
    public InventoryManager inventoryManager;
    private int count;
    private int redTint;
    private int greenTint;
    private int blueTint;
    private bool mixingPaint;

    private float redAmount;
    private float greenAmount;
    private float blueAmount;

    public float timer;

    int mixRed;
    int mixBlue;
    int mixGreen;

    public float colorChangeSpeed;

    public void MixPaint(int red, int green, int blue)
    {
        if (inventoryManager.getStirSticks() > 0)
        {
            mixingPaint = true;
            Cursor.lockState = CursorLockMode.None;
            inventoryManager.useStirStick();
            redTint = red;
            greenTint = green;
            blueTint = blue;
        }
        else
        {
            Debug.Log("No more stir sticks");
        }
    }

    public void resetPaint()
    {
        Color paintColor;
        paintColor = new Color(255 / 255f,255/255f,255/255f);
        paintMaterial.SetColor("_Color", paintColor);
    }
    void Start()
    {
        paintCanPlaceScript = PaintCanPlaceObject.GetComponent<PaintCanPlace>();
        redTint = -999;
        greenTint = -999;
        blueTint = -999;
        colorChangeSpeed = .2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!paintCanPlaceScript.GetCanPickup() && paintCanPlaceScript.GetIsPaintPlaced())
        {
            if (count == 0)
            {
                paintCanMaterial = paintCanPlaceScript.getPaintCan();
                count++;
            }
        }
        else
        {
            count = 0;
        }
        if (mixingPaint == true)
        {
            if (redTint == 0 && greenTint == 0 && blueTint == 0)
            {
                changePaintColor(255,255,255);
            }
            else
            {
                if (mixRed <= redTint && mixGreen <= greenTint && mixBlue <= blueTint)
                {
                     
                    Cursor.lockState = CursorLockMode.Locked;
                    mixingPaint = false;  
                    changePaintColor(redTint, greenTint, blueTint);
                }
                else
                {
                    float mouseX = Input.GetAxis("Mouse X");
                    float mouseY = Input.GetAxis("Mouse Y");

                    //Debug.Log(mouseX + " " + mouseY);
                    int change = (int)(Mathf.Abs(mouseX+mouseY));
                    if (mixRed != redTint || mixRed > greenTint)
                    {
                        mixRed -= change;
                    }
                    if (mixGreen != greenTint || mixGreen > greenTint)
                    {
                        mixGreen -= change;
                    }
                    if (mixBlue != blueTint || mixBlue > blueTint)
                    {
                        mixBlue -= change;
                    }
                    //Debug.Log(mixRed + " "+  mixGreen +" "+ mixBlue);
                    
                    if (timer >= colorChangeSpeed)
                    {
                        changePaintColor(mixRed, mixGreen, mixBlue);
                        timer = 0;
                        Debug.Log("Update");
                    }
                    timer += Time.deltaTime;
                }
            }
        }
        else
        {
            mixRed = 255;
            mixBlue = 255;
            mixGreen = 255;
        }
    }

    public void changePaintColor(int red, int green, int blue)
    {
        redAmount = red / 255f;
        greenAmount = green / 255f;
        blueAmount = blue / 255f;
        Color paintColor = new Color(redAmount, greenAmount, blueAmount);
        paintMaterial.SetColor("_Color", paintColor);
    }

    public int getRedTintAmount()
    {
        return redTint;
    }
    public int getGreenTintAmount()
    {
        return greenTint;
    }
    public int getBlueTintAmount()
    {
        return blueTint;
    }
}
