using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV, velovity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
            rb.velocity = velovity;
        }
        
        rb.AddForce(Vector3.Cross(rb.angularVelocity, rb.velocity));
    }
}
