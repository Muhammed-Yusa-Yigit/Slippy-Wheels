using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DirCloser : MonoBehaviour
{
    public GameObject Obje;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Obje.SetActive(false);
        }
    }
}
