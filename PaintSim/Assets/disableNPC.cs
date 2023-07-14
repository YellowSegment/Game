using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableNPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC") || other.CompareTag("NPCDone"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Entered");
            other.gameObject.GetComponent<Animator>().SetBool("isMoving", false);
        }
    }
}
