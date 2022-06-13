using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedscript : MonoBehaviour
{

    public Text speedText;
    public CarDrive speed;
    private int intSpeed;
    private string endSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speedText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        intSpeed = (int)speed.speedinput /10;
        endSpeed = intSpeed.ToString();
        speedText.text = "KPH " + endSpeed.ToUpper();
    }
}
