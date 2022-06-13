using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chooseship : MonoBehaviour
{
    public GameObject Ship1, Ship2;
    public float shipnumber = 1f;
    // Update is called once per frame
    void Start()
    {
        shipnumber = GlobalVariable.shipmodel;
        if(shipnumber == 1) 
        {
            Ship1.gameObject.SetActive(true);
            Ship2.gameObject.SetActive(false);
        }
        else if(shipnumber == 2)
        {
            Ship1.gameObject.SetActive(false);
            Ship2.gameObject.SetActive(true);
        }
    }
}
