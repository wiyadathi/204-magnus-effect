using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV, torque;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Inertia();
        
        if (Input.GetMouseButtonDown(0))
        {
            RotateAV();
        }
        else if(Input.GetMouseButtonDown(1))
        {
            RotateTorque();
        }
    }
    
    void Inertia()
    {
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        rb.angularVelocity = rb.inertiaTensor;
        
        Debug.Log( this.name + " Inertia: " + rb.inertiaTensor);
    }
    void RotateTorque()
    {
        rb.AddTorque(torque);
    }
    void RotateAV()
    {
        rb.angularVelocity = angularV;
    }



}
