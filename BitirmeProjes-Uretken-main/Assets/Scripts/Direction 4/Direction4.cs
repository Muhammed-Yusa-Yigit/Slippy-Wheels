using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Direction4 : MonoBehaviour
{
    public GameObject Directionk;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Directionk.SetActive(true);
        }
    }
}

