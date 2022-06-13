using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedscript : MonoBehaviour
{

    public Text speedText;
    public CarDrive speed;
    private int intSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speedText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        intSpeed = (int)speed.speedinput /10;
        speedText.text = "KPH " + intSpeed.ToString();
    }
}
