using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour
{
    public GameObject panel;
    public Image imagePanel;
    public Image imgButtonStart;

    public GameObject papelCerrado;
    public GameObject papelAbierto;

    public Sprite[] arraySprites;
    public Sprite[] arraySpriteButton;


    public Button btnStartRuleta;
    public Text txtTexto;

    private int valueCollision;
    private int valorActivacion;

    public AudioSource audio;

    public void Start()
    {
        valueCollision = 0;
        valorActivacion = 0;

        float volumen = PlayerPrefs.GetFloat("ValorSlider", 0);
        audio.volume = volumen;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("car"))
        {
            valueCollision = 1;
        }

        if (collision.gameObject.tag.Equals("1thousandollars"))
        {
            valueCollision = 2;
        }

        if (collision.gameObject.tag.Equals("10dollars"))
        {
            valueCollision = 3;
        }

        if (collision.gameObject.tag.Equals("boxHide2"))
        {
            valueCollision = 4;
        }

        if (collision.gameObject.tag.Equals("100thousanddollars"))
        {
            valueCollision = 5;
        }

        if (collision.gameObject.tag.Equals("house"))
        {
            valueCollision = 6;            
        }

        if (collision.gameObject.tag.Equals("bike"))
        {
            valueCollision = 7;
        }

        if (collision.gameObject.tag.Equals("bottle"))
        {
            valueCollision = 8;
        }

        if (collision.gameObject.tag.Equals("boxHide"))
        {
            valueCollision = 9;
        }

        if (collision.gameObject.tag.Equals("10thousandollars"))
        {
            valueCollision = 10;
        }

        if (collision.gameObject.tag.Equals("wood"))
        {
            valueCollision = 11;
        }
        
        if (collision.gameObject.tag.Equals("mountain"))
        {
            valueCollision = 12;
        }
    }


    public void MostrarPanel()
    {
        if(valorActivacion == 0)
        {
            valorActivacion = 1;
            imgButtonStart.sprite = arraySpriteButton[0];
        } else
        {            
            switch (valueCollision)
            {
                case 1:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;                    
                    valorActivacion = 0;
                    break;
                case 2:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 3:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 4:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 5:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 6:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 7:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 8:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 9:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 10:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 11:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
                case 12:
                    panel.SetActive(true);
                    btnStartRuleta.enabled = false;
                    valorActivacion = 0;
                    break;
            }

            imgButtonStart.sprite = arraySpriteButton[1];

            StartCoroutine(StartCorrutinePanel());
        }

        

    }

    IEnumerator StartCorrutinePanel()
    {        

        imagePanel.sprite = arraySprites[0];        

        yield return new WaitForSeconds(1f);

        imagePanel.sprite = arraySprites[1];
        audio.Play();

        yield return new WaitForSeconds(0.3f);
        
        papelCerrado.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        papelCerrado.SetActive(false);
        papelAbierto.SetActive(true);        


        switch (valueCollision)
        {
            case 1:
                txtTexto.text = "Haz ganado una semana estabilidad emocional";
                break;
            case 2:
                txtTexto.text = "Haz ganado un fin de semana en el campus de la universidad blas pascal";
                break;
            case 3:
                txtTexto.text = "Haz ganado un 80% de descuento en papel higienico de segunda mano";
                break;
            case 4:
                txtTexto.text = "Haz ganado un palta hass levemente magullada";
                break;
            case 5:
                txtTexto.text = "Haz ganado una play station 5 edicion limitada epic golden, no le funca el microprocesador";
                break;
            case 6:
                txtTexto.text = "Haz ganado un voucher de $50.000 en posa vasos de carton";
                break;
            case 7:
                txtTexto.text = "Haz ganado una mes de estabilidad emocional";
                break;
            case 8:
                txtTexto.text = "Haz ganado un fin de semana en un monoambiente sin ventilación";
                break;
            case 9:
                txtTexto.text = "Haz ganado un 10% de descuento en pañuelos de segunda mano";
                break;
            case 10:
                txtTexto.text = "Haz ganado una bufanda de alambre";
                break;
            case 11:
                txtTexto.text = "Haz ganado una pescera con larvas de mosquitos";
                break;
            case 12:
                txtTexto.text = "Haz ganado una cena romantica en el comedor del hospital";
                break;
        }

        yield return new WaitForSeconds(5f);

        imgButtonStart.sprite = arraySpriteButton[2];
        txtTexto.text = "";
        papelAbierto.SetActive(false);
        panel.SetActive(false);
        imagePanel.sprite = null;
        btnStartRuleta.enabled = true;

    }

}
