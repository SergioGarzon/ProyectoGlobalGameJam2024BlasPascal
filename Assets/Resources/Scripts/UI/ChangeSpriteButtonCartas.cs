using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteButtonCartas : MonoBehaviour
{

    public Button[] btnCartasJuego;
    public Image[] btnCarta;
    public Sprite[] imagen1;

    public AudioSource audio;

    private int numero;
    private int bloqueoSegundaVuelta;

    public void Start()
    {
        numero = 0;
        bloqueoSegundaVuelta = 0;

        float volumen = PlayerPrefs.GetFloat("ValorSlider", 0);
        audio.volume = volumen;

    }

    public void mostrarCarta(int numeroCarta)
    {

        switch(numeroCarta)
        {
            case 1:
                setearCarta(btnCarta[0]);
                btnCartasJuego[0].enabled = false;
                break;
            case 2:
                setearCarta(btnCarta[1]);
                btnCartasJuego[1].enabled = false;
                break;
            case 3:
                setearCarta(btnCarta[2]);
                btnCartasJuego[2].enabled = false;
                break;
            case 4:
                setearCarta(btnCarta[3]);
                btnCartasJuego[3].enabled = false;
                break;
            case 5:
                setearCarta(btnCarta[4]);
                btnCartasJuego[4].enabled = false;
                break;
            case 6:
                setearCarta(btnCarta[5]);
                btnCartasJuego[5].enabled = false;
                break;
            case 7:
                setearCarta(btnCarta[6]);
                btnCartasJuego[6].enabled = false;
                break;
            case 8:
                setearCarta(btnCarta[7]);
                btnCartasJuego[7].enabled = false;
                break;
        }
    }


    public void setearCarta(Image botonImg)
    {
        Image imgBtnCambiar = botonImg;

        int valor = 0;

        do
        {
            valor = (int)Random.Range(1, 4);

        } while (valor == numero);       
                
        switch (valor)
        {
            case 1:
                numero = 1;
                imgBtnCambiar.sprite = imagen1[0];
                break;
            case 2:
                numero = 2;
                imgBtnCambiar.sprite = imagen1[1];
                break;
            case 3:
                numero = 3;
                imgBtnCambiar.sprite = imagen1[2];
                break;
            case 4:
                numero = 4;
                imgBtnCambiar.sprite = imagen1[3];
                break;
        }

        audio.Play();

        bloqueoSegundaVuelta++;

        if(bloqueoSegundaVuelta == 2)
            bloquearBotones();
    }


    public void bloquearBotones()
    {      

        for(int i = 0; i < btnCartasJuego.Length; i++)
        {
            btnCartasJuego[i].enabled = false;
        }

        StartCoroutine(VolverAActivarBotonesyResetear());
    }


    IEnumerator VolverAActivarBotonesyResetear()
    {

       yield return new WaitForSeconds(1.5f);

        for (int i = 0; i < btnCartasJuego.Length; i++)
        {
            btnCartasJuego[i].enabled = true;
            btnCarta[i].sprite = imagen1[4];
        }


        audio.Play();


        bloqueoSegundaVuelta = 0;

    }



}
