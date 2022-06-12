using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
public float lifes = 3;
public Transform spawnpoint;
public GameObject spaceship;


    void OnTriggerEnter(Collider other) {
        if (lifes > 1)
        {
            lifes = lifes - 1;
            spaceship.transform.rotation = Quaternion.Euler(0, 0, 0);
            other.transform.position = spawnpoint.transform.position;
            Debug.Log("test");
        }
        else {SceneManager.LoadScene(2);}

    }
}
