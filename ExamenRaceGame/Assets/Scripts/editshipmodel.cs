using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editshipmodel : MonoBehaviour
{
    public void redship()
    {
        GlobalVariable.shipmodel = 1f;
    }

    public void purpleship()
    {
        GlobalVariable.shipmodel = 2f;
    }
}
