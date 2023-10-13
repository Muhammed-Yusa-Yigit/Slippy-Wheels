using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dİrection3 : MonoBehaviour
{
    public GameObject Directionc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Directionc.SetActive(true);
        }
    }
}
