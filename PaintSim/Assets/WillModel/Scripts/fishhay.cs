using UnityEngine;

public class fishhay : MonoBehaviour
{
    public GameObject parentObject;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        // Copy parent object position
        transform.position = parentObject.transform.position + offset;

        // Calculate rotation offset
        Quaternion rotationOffset = Quaternion.Inverse(parentObject.transform.rotation);

        // Apply rotation to attached object
        transform.rotation = rotationOffset * Quaternion.identity;
    }
}