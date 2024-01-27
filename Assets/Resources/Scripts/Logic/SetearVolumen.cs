using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetearVolumen : MonoBehaviour
{
    public Slider volume;


    public void Start()
    {
        float valor = PlayerPrefs.GetFloat("ValorSlider", 0);


        volume.value = valor;
    }

    public void SetearVolumenIngresar()
    {
        float valor = volume.value;

        PlayerPrefs.SetFloat("ValorSlider", valor);
        PlayerPrefs.Save();
    }




}
