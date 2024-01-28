using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RegularVolumenInicial : MonoBehaviour
{
    public AudioSource sonido;
    public AudioSource sonido2;

    public Slider sldVolume;



    private void Update()
    {
        sonido.volume = sldVolume.value;

        sonido2.volume = sldVolume.value;



    }
}
