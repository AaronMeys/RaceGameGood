using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
private Rigidbody rb;
public float speed;
public float turnspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-Vector3.forward * speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnspeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * turnspeed);
        }
    }
}