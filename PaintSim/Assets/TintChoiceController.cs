using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TintChoiceController : MonoBehaviour
{
    public Button redTintController;
    public Button greenTintController;
    public Button blueTintController;
    
    public Text fastPourText;

    public bool fastPour;
    public bool isRed;
    public bool isGreen;
    public bool isBlue;

    public GameObject redtintOpen;
    public GameObject greenTintOpen;
    public GameObject blueTintOpen;




    private ColorBlock normalColorBlock; // Stores the normal color of the buttons
    private Color normalColor; // Stores the normal color of the UI buttons
    private Color selectedColor; // Stores the selected color of the UI buttons

    private void Start()
    {
        fastPour = true;
        normalColorBlock = redTintController.colors; // Store the normal color of the buttons

        normalColor = new Color(118f / 255f, 118f / 255f, 118f / 255f); // Set the normal color to RGB (118, 118, 118)
        selectedColor = redTintController.colors.selectedColor; // Store the selected color of the UI buttons

        redTintController.onClick.AddListener(SelectRedTint);
        greenTintController.onClick.AddListener(SelectGreenTint);
        blueTintController.onClick.AddListener(SelectBlueTint);
        // Set the initial normal color of the buttons
        SetButtonColors(redTintController, normalColor);
        SetButtonColors(greenTintController, normalColor);
        SetButtonColors(blueTintController, normalColor);
        redtintOpen.SetActive(false);
        greenTintOpen.SetActive(false);
        blueTintOpen.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            changeFastPour();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectRedTint();
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectGreenTint();
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectBlueTint();
            
        }
    }

    public void changeFastPour()
    {
        if (fastPour == true)
        {
            fastPour = false;
            fastPourText.text = "Fast Pour OFF";
        }
        else 
        {
            fastPour = true;
            fastPourText.text = "Fast Pour ON";
        }
    }
    public void SelectRedTint()
    {

        // Change the colors of the buttons
        SetButtonColors(redTintController, selectedColor);
        ResetButtonColorsExcept(redTintController);
        isRed = true;
        isBlue = false;
        isGreen = false;

        redtintOpen.SetActive(true);
        greenTintOpen.SetActive(false);
        blueTintOpen.SetActive(false);
    }

    public void SelectGreenTint()
    {

        // Change the colors of the buttons
        SetButtonColors(greenTintController, selectedColor);
        ResetButtonColorsExcept(greenTintController);
        isRed = false;
            isBlue = false;
            isGreen = true;
        redtintOpen.SetActive(false);
        greenTintOpen.SetActive(true);
        blueTintOpen.SetActive(false);
    }

    public void SelectBlueTint()
    {

        // Change the colors of the buttons
        SetButtonColors(blueTintController, selectedColor);
        ResetButtonColorsExcept(blueTintController);
        isRed = false;
            isBlue = true;
            isGreen = false;
            redtintOpen.SetActive(false);
        greenTintOpen.SetActive(false);
        blueTintOpen.SetActive(true);
    }

    private void SetButtonColors(Button button, Color color)
    {
        // Modify the ColorBlock of the button to set the selected color
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = color;
        button.colors = colorBlock;
    }

    private void ResetButtonColorsExcept(Button button)
    {
        // Reset the colors of buttons other than the selected one to the normal color
        if (button != redTintController)
        {
            SetButtonColors(redTintController, normalColor);
        }
        if (button != greenTintController)
        {
            SetButtonColors(greenTintController, normalColor);
        }
        if (button != blueTintController)
        {
            SetButtonColors(blueTintController, normalColor);
        }
    }


    public bool GetIsRed()
    {
        return isRed;
    }
    public bool GetIsGreen()
    {
        return isGreen;
    }
    public bool GetIsBlue()
    {
        return isBlue;
    }
    public bool GetIsFastPour()
    {
        return fastPour;
    }
}
