using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameBackMM : MonoBehaviour
{
    public void CameBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
