using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTimer : MonoBehaviour
{
    public Text timeText;
    private int EndMinutes = GlobalVariable.finalMinutes;
    private double EndSeconds = GlobalVariable.finalSeconds;


    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
        timeText.text = "Y O U R  F I N A L  T I M E  I S\n\n" + EndMinutes.ToString() + "\"" + EndSeconds.ToString("n2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
