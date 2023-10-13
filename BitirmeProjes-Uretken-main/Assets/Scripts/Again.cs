using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    public void again()
    {
        SceneManager.LoadScene("Sample Scene");
    }
}
