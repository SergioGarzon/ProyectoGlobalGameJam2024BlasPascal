using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularVolumen : MonoBehaviour
{
    public AudioSource sonido;

    public void Start()
    {
        float volumen = PlayerPrefs.GetFloat("ValorSlider", 0);
        sonido.volume = volumen;


        sonido.Play();
    }

    public void DetenerSonido()
    {
        sonido.Stop();
    }

}
