using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Dir6Closer : MonoBehaviour
{
    public GameObject Objep;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Objep.SetActive(false);
        }
    }
}
