using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneButton : MonoBehaviour
{

    public Image btnStart;
    public Sprite btnStart1;
    public Sprite btnStart2;

    public Image btnQuit;
    public Sprite btnQuit1;
    public Sprite btnQuit2;

    private string nombreEscena;

    public AudioSource sonidoIniciarEscena;

    private int contadorEscena;


    public void Start()
    {
        nombreEscena = "";
        contadorEscena = PlayerPrefs.GetInt("CambioEscena", 0);
    }

    public void ChangeSceneRandom()
    {

        /*
        int valorRandom = (int)(Random.Range(0, 99) + 1);
              

        if (valorRandom >= 0 && valorRandom <= 16)
            nombreEscena = "VideoScene";

        if (valorRandom >= 17 && valorRandom <= 32)
            nombreEscena = "QuienEsCharly";

        if (valorRandom >= 33 && valorRandom <= 48)
            nombreEscena = "QuienEsMarley";

        if (valorRandom >= 49 && valorRandom <= 65)
            nombreEscena = "Cartas";

        if (valorRandom >= 66 && valorRandom <= 81)
            nombreEscena = "Frogger";

        if (valorRandom >= 82 && valorRandom <= 100)
            nombreEscena = "BuscandoWally";
        */


        switch (contadorEscena)
        {
            case 0: nombreEscena = "VideoScene"; PlayerPrefs.SetInt("CambioEscena", 1); break;
            case 1: nombreEscena = "QuienEsMarley"; PlayerPrefs.SetInt("CambioEscena", 2); break;
            case 2: nombreEscena = "BuscandoWally"; PlayerPrefs.SetInt("CambioEscena", 3); break;
            case 3: nombreEscena = "QuienEsCharly"; PlayerPrefs.SetInt("CambioEscena", 4); break;
            case 4: nombreEscena = "PruebaFrogger"; PlayerPrefs.SetInt("CambioEscena", 5); break;
            case 5: nombreEscena = "Cartas"; PlayerPrefs.SetInt("CambioEscena", 0); break;
        }

        PlayerPrefs.Save();
        
        StartCoroutine(CorrutinaBotonesEscena());
    }

    IEnumerator CorrutinaBotonesEscena()
    {
        yield return new WaitForSeconds(0.2f);

        btnStart.sprite = btnStart2;
        btnQuit.sprite = btnQuit1;

        float valor = PlayerPrefs.GetFloat("ValorSlider", 0);
        sonidoIniciarEscena.volume = valor;

        sonidoIniciarEscena.Play();

        yield return new WaitForSeconds(0.6f);

        SceneManager.LoadScene(nombreEscena);
    }

    public void QuitGame()
    {
        StartCoroutine(CorrutinaBotonesEscenaQuitar());
    }

    IEnumerator CorrutinaBotonesEscenaQuitar()
    {
        yield return new WaitForSeconds(0.2f);

        btnQuit.sprite = btnQuit2;
        btnStart.sprite = btnStart1;

        yield return new WaitForSeconds(0.6f);

        PlayerPrefs.SetInt("CambioEscena", 0);
        PlayerPrefs.Save();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }




}
