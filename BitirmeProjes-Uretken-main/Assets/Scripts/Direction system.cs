using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Directionsystem : MonoBehaviour
{
    public GameObject Direction;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Direction.SetActive(true);
        }
    }
}
