using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform ObjectGrabPointTransform;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform ObjectGrabPointTransform)
    {
        this.ObjectGrabPointTransform = ObjectGrabPointTransform;
        objectRigidbody.useGravity = false;
    }

    public void Drop()
    {
        this.ObjectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (ObjectGrabPointTransform != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, ObjectGrabPointTransform.position, Time.deltaTime * 15f);
            objectRigidbody.MovePosition(newPosition);
        }       
    }
}
