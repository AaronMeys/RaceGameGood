using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifescript : MonoBehaviour
{

    public Text lifeText;
    public Fall lifes;

    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "lives " + lifes.lifes.ToString();
    }
}
