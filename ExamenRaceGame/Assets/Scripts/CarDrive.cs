using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardaccel = 8f, reverseaccel = 4f, maxspeed = 50f, turnspeed = 180, gravityForce = 10f, dragonground = 3f, rotationDamp = 3f, boostDuration = 5f, boostpower = 2f;
    private float accelvar, boost;
    public float speedinput, turninput;
    private bool grounded, turbo;
    public LayerMask whatIsGround, whatIsTurbo;
    public float groundray = .5f;
    public Transform groundRayPoint;


    // Start is called before the first frame update
    void Start()
    {
        rb.transform.parent = null;
        accelvar = Forwardaccel;
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
        if (grounded || turbo)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turninput * turnspeed * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
        }
        transform.position = rb.transform.position;
    }

    void FixedUpdate()
    {
        grounded = false;
        turbo = false;
        RaycastHit hit;

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundray, whatIsGround))
        {
            grounded = true;

            Quaternion rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationDamp * Time.deltaTime);
        }

        else if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundray, whatIsTurbo))
        {
            turbo = true;

            Quaternion rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationDamp * Time.deltaTime);
        }

        if (grounded)
        {
            rb.drag = dragonground;
            if (boost > 0)
            {
                Forwardaccel = accelvar * boostpower;
                boost = boost - Time.deltaTime;
            }
            else
            {
                Forwardaccel = accelvar;
            }
            if (Mathf.Abs(speedinput) > 0)
            {
                rb.AddForce(transform.forward * speedinput);
            }
        }
        else if (turbo)
        {
            rb.drag = dragonground;
            Forwardaccel = accelvar * boostpower;
            boost = boostDuration;

            if (Mathf.Abs(speedinput) > 0)
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