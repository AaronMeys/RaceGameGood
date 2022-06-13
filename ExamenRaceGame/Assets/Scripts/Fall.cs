using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    public float lifes = 3;
    public Transform spawnpoint, checkpoint1;
    public GameObject spaceship;
    public float checkpoint = 0f, rotationspawn = 0, rotationcheck1 = 180;
    public checkpointcounter checkpointcounter;

    void Update()
    {
        checkpoint = checkpointcounter.checkpoint;
    }


    void OnTriggerEnter(Collider other)
    {
        if (lifes > 1)
        {
            lifes = lifes - 1;
            if (checkpoint == 0f)
            {
                spaceship.transform.rotation = Quaternion.Euler(0, rotationspawn, 0);
                other.transform.position = spawnpoint.transform.position;
            }
            else if (checkpoint == 1f)
            {
                spaceship.transform.rotation = Quaternion.Euler(0, rotationcheck1, 0);
                other.transform.position = checkpoint1.transform.position;
            }
        }
        else { SceneManager.LoadScene(2); }

    }
}