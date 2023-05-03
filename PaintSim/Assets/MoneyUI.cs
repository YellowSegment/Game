using UnityEngine;
using UnityEngine.UI;

// public class MoneyUI : MonoBehaviour
// {
//     private Text moneyText;
//     private Money moneyScript;

//     void Start()
//     {
//         // Find the Text component on this object
//         //moneyText = GetComponent<moneyText>();

//         // Find the Money script on the player object
//         GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
//         if (playerObject != null)
//         {
//             moneyScript = playerObject.GetComponent<Money>();
//         }
//         else
//         {
//             Debug.LogError("Player object not found.");
//         }
//     }

//     void Update()
//     {
//         if (moneyScript != null)
//         {
//             // Update the Text component's text value with the current money amount
//             if (moneyText != null) // make sure the moneyText variable is not null
//             {
//                 moneyText.text = "Money: $" + moneyScript.money.ToString("0.00");
//             }
//             else
//             {
//                 Debug.LogError("Money Text component not found.");
//             }
//         }
//         else
//         {
//             Debug.LogError("Money script not found.");
//         }
//     }
// }


    // void Start()
    // {
    //     // Find the Text component on this object
    //     moneyText = GetComponent<Text>();

    //     // Find the Money script on the player object
    //     moneyScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Money>();
    // }

    // void Update()
    // {
    //     // Update the Text component's text value with the current money amount
    //     moneyText.text = "Money: $" + moneyScript.money.ToString("0.00");
    //     Debug.Log("Player object: " + GameObject.FindGameObjectWithTag("Player"));

    // }
//}
