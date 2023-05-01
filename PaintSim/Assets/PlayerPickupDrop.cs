using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask AllowPickupLayerMask;
    [SerializeField] private Transform ObjectGrabPointTransform;
    float pickupDistance = 2f;

    private ObjectGrabable objectGrabable;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabable == null)
            {
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit RaycastHit, pickupDistance))
                    {
                        if(RaycastHit.transform.TryGetComponent(out objectGrabable))
                        {
                            objectGrabable.Grab(ObjectGrabPointTransform);
                        }
                    }
            }
            else
            {
                objectGrabable.Drop();
                objectGrabable = null;
            }
        }
        
    }
}
