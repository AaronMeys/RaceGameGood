using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardaccel = 8f,reverseaccel =4f,maxspeed = 50f,turnspeed = 180;
    private float speedinput ,turninput;


    // Start is called before the first frame update
    void Start()
    {
        rb.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedinput = 0f;
        if (Input.GetAxis("Vertical") > 0){
            speedinput = Input.GetAxis("Vertical") * Forwardaccel * 1000f;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedinput = Input.GetAxis("Vertical") * reverseaccel * 1000f;
        }
        
        turninput = Input.GetAxis("Horizontal");
        
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turninput* turnspeed * Time.deltaTime, 0f));
        
        transform.position = rb.transform.position;
    }

    void FixedUpdate()
    {
        if(Mathf.Abs(speedinput) > 0)
        {
            rb.AddForce(transform.forward * speedinput);
        }
    }

    
}
