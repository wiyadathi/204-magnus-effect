using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MInertia : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        Debug.Log("Inertia: " + rb.inertiaTensor);
    }
}
