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
    private int count;
    private int redTint;
    private int greenTint;
    private int blueTint;

    public void MixPaint(int red, int green, int blue)
    {
        redTint = red;
        greenTint = green;
        blueTint = blue;
        float redAmount = red / 255f;
        float greenAmount = green / 255f;
        float blueAmount = blue / 255f;

        Color paintColor;
        if (redAmount == 0 && greenAmount == 0 && blueAmount == 0)
        {
            paintColor = new Color(255,255,255);
        }
        else
        {
            paintColor = new Color(redAmount, greenAmount, blueAmount);   
        }
        paintMaterial.SetColor("_Color", paintColor);
    }
    void Start()
    {
        paintCanPlaceScript = PaintCanPlaceObject.GetComponent<PaintCanPlace>();
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
                //TODO: NEED TO IMPLEMENT A WAY TO GET A MATERIAL FROM THE PAINTCANMATERIAL SCRIPT
            }
        }
        else
        {
            count = 0;
        }
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
