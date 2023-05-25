using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintMixer : MonoBehaviour
{
    public Material paintMaterial;
    // Start is called before the first frame update

    public void MixPaint(int red, int green, int blue)
    {
        float redAmount = red / 255f;
        float greenAmount = green / 255f;
        float blueAmount = blue / 255f;
        Color paintColor = new Color(redAmount, greenAmount, blueAmount);

        paintMaterial.SetColor("_Color", paintColor);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
