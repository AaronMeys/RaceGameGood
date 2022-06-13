using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timescript : MonoBehaviour
{

    public Text timeText;
    private float timer;
    private double inttime;
    private int minutes = 0;


    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        inttime = (double)timer;
        if (timer > 59.99)
        {
            minutes++;
            timer = 0;
        }
        timeText.text = minutes.ToString() + "\"" + inttime.ToString("n2");

        GlobalVariable.finalMinutes = minutes;
        GlobalVariable.finalSeconds = inttime;

    }
}
