using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointcounter : MonoBehaviour
{
    public float checkpoint = 0f, checkPointNum;
    


    void OnTriggerEnter(Collider other)
    {
        checkpoint = checkPointNum;
    }
}