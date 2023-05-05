using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    public Transform sitPoint;
    public float sitRotationOffset = 0f;
    public LayerMask chairLayerMask;
    public KeyCode interactKey = KeyCode.E;

    private bool isSitting = false;
    private GameObject chairObject = null;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    private void Update()
    {
        if (!isSitting && Input.GetKeyDown(interactKey))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f, chairLayerMask))
            {
                Chair chair = hit.collider.GetComponent<Chair>();
                if (chair != null)
                {
                    chairObject = hit.collider.gameObject;
                    transform.position = chair.sitPoint.position;
                    transform.rotation = Quaternion.Euler(chair.transform.rotation.eulerAngles + new Vector3(0f, chair.sitRotationOffset, 0f));
                    GetComponent<CharacterController>().enabled = false;
                    isSitting = true;
                }
            }
        }
        else if (isSitting && Input.GetKeyDown(interactKey))
        {
            if (chairObject != null)
            {
                transform.position = originalPosition;
                transform.rotation = originalRotation;
                GetComponent<CharacterController>().enabled = true;
                chairObject = null;
                isSitting = false;
            }
        }
        
        // Keep the player seated in the chair if they are sitting
        if (isSitting)
        {
            transform.position = chairObject.transform.position;
            transform.rotation = Quaternion.Euler(chairObject.transform.rotation.eulerAngles + new Vector3(0f, sitRotationOffset, 0f));
        }
    }
}
