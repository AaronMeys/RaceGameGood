using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    public AudioSource caraudio;
    public CarDrive car;

    void Update()
    {
        if (car.speedinput != 0)
        {
            if (!caraudio.isPlaying)
            {
                caraudio.Play();

            }
            
        }
    }
}
