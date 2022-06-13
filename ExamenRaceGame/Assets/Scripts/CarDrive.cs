using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardaccel = 8f,reverseaccel =4f,maxspeed = 50f,turnspeed = 180, gravityForce = 10f, dragonground = 3f, rotationDamp = 3f;
    public float speedinput ,turninput;
    private bool grounded;
    public LayerMask whatIsGround;
    public float groundray = .5f;
    public Transform groundRayPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedinput = 0f;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedinput = Input.GetAxis("Vertical") * Forwardaccel * 1000f;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedinput = Input.GetAxis("Vertical") * reverseaccel * 1000f;
        }
        
        turninput = Input.GetAxis("Horizontal");
        if(grounded)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turninput* turnspeed * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
        }
        transform.position = rb.transform.position;
    }

    void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundray, whatIsGround))
        {
            grounded = true;

            Quaternion rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationDamp * Time.deltaTime);
        }
        if (grounded)
        {
            rb.drag = dragonground;

            if(Mathf.Abs(speedinput) > 0)
            {
                rb.AddForce(transform.forward * speedinput);
            }
        }
        else
        {
            rb.drag = 0.1f;
            rb.AddForce(Vector3.up * -gravityForce * 100);
        }
    }

    
}
