using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dir3Closer : MonoBehaviour
{
    public GameObject Objec;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Objec.SetActive(false);
        }
    }
}
