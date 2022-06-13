using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    public AudioSource audiogert;
    public CarDrive car;
    private bool playing;

    void Update()
    {
        if (car.speedinput > 0)
        {
            if (!audiogert.isPlaying){
            audiogert.Play();
            }
        }
    }
}
