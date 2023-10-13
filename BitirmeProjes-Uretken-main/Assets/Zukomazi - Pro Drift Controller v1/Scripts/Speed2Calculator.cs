using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SpeedCalculator : MonoBehaviour
{
    float zamanSayaci = 180;
    bool oyunTamam = false;
    bool oyunDevam = true;
    public float Speed;
    public Rigidbody rb;

    public Text zaman,durum;
    public Text SpeedText;
    public Text GearText;
    public Text RPMText;


    void FixedUpdate()
    {
        if (oyunDevam)
        {
            Vector3 vel = rb.velocity;
            Speed = rb.velocity.magnitude * 2.23693629f;

            SpeedText.text = Speed.ToString("0");
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    void Update()
    {
        if (oyunDevam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
        }
        else
        {
            durum.text = "Zamanınız Doldu";
        }

        if (zamanSayaci < 0)
        {
            oyunDevam = false;
          
            
           SceneManager.LoadScene("Kaybetme2");
            
        }
    }


}
