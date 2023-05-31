using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TintChoiceController : MonoBehaviour
{
    public Button redTintController;
    public Button greenTintController;
    public Button blueTintController;

    private ColorBlock normalColorBlock; // Stores the normal color of the buttons

    private void Start()
    {
        normalColorBlock = redTintController.colors; // Store the normal color of the buttons

        redTintController.onClick.AddListener(SelectRedTint);
        greenTintController.onClick.AddListener(SelectGreenTint);
        blueTintController.onClick.AddListener(SelectBlueTint);
    }

    private void Update()
    {
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

    public void SelectRedTint()
    {
        Debug.Log("Red");

        // Change the colors of the buttons
        SetButtonColors(redTintController.colors.selectedColor);
        ResetButtonColorsExcept(redTintController);
    }

    public void SelectGreenTint()
    {
        Debug.Log("Green");

        // Change the colors of the buttons
        SetButtonColors(greenTintController.colors.selectedColor);
        ResetButtonColorsExcept(greenTintController);
    }

    public void SelectBlueTint()
    {
        Debug.Log("Blue");

        // Change the colors of the buttons
        SetButtonColors(blueTintController.colors.selectedColor);
        ResetButtonColorsExcept(blueTintController);
    }

    private void SetButtonColors(Color color)
    {
        // Modify the ColorBlock of each button to set the selected color
        ColorBlock colorBlock = redTintController.colors;
        colorBlock.normalColor = color;
        colorBlock.highlightedColor = color;
        colorBlock.pressedColor = color;
        redTintController.colors = colorBlock;

        colorBlock = greenTintController.colors;
        colorBlock.normalColor = color;
        colorBlock.highlightedColor = color;
        colorBlock.pressedColor = color;
        greenTintController.colors = colorBlock;

        colorBlock = blueTintController.colors;
        colorBlock.normalColor = color;
        colorBlock.highlightedColor = color;
        colorBlock.pressedColor = color;
        blueTintController.colors = colorBlock;
    }

    private void ResetButtonColorsExcept(Button button)
    {
        // Reset the colors of buttons other than the selected one to the normal color
        if (button != redTintController)
            redTintController.colors = normalColorBlock;
        if (button != greenTintController)
            greenTintController.colors = normalColorBlock;
        if (button != blueTintController)
            blueTintController.colors = normalColorBlock;
    }
}
