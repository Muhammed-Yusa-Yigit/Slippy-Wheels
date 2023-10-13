using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Direction6 : MonoBehaviour
{
    public GameObject Directionp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Directionp.SetActive(true);
        }
    }
}
