// // BuyItem.cs
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BuyItem : MonoBehaviour
// {
//     public GameObject PlayablePlayer;

//     private void Start()
//     {
//         // Assign PlayablePlayer to the GameObject that has the Money script attached to it
//         PlayablePlayer = GameObject.FindGameObjectWithTag("Player");
//     }

//     void Update()
//     {
//         //This is just for testing
//         if (Input.GetButtonDown("Buy"))
//         {
//             PlayablePlayer.GetComponent<Money>().PurchaseItem(1.99);
//         }       
//     }
// }