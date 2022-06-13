using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoincounter : MonoBehaviour
{
    public float checkpoint = 0f;
    

    void OnTriggerEnter(Collider other) {
        checkpoint = 1;
    }
}
