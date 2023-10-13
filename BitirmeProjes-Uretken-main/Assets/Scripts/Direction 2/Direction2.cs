using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Direction2 : MonoBehaviour
{
    public GameObject Directionsc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Directionsc.SetActive(true);
        }
    }
}
