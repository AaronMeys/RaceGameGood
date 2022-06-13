using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timescript : MonoBehaviour
{
    public Text timeText;
    private float timer;
    private int inttime;


    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        inttime = (int)timer;
        timeText.text = "Time " + inttime.ToString();
    }
}
