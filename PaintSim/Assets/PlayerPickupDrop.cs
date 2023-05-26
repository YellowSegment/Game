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
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit hit, pickupDistance))
                {
                    if (hit.transform.gameObject.layer == LayerMask.NameToLayer("AllowPickup"))
                    {
                        if (hit.transform.TryGetComponent(out objectGrabable))
                        {
                            objectGrabable.Grab(ObjectGrabPointTransform);
                        }
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
