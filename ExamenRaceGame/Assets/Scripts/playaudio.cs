using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    public AudioSource caraudio;
    public CarDrive car;

    void Update()
    {
        if ( (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.S)) )
        {
            if (!caraudio.isPlaying)
            {
                caraudio.Play();

            }
            else
            {
                caraudio.Stop();
            }

        }
    }
}
