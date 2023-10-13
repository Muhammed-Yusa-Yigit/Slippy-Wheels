using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dir4Closer : MonoBehaviour
{
    public GameObject Objek;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Objek.SetActive(false);
        }
    }
}
