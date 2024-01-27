using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneGame : MonoBehaviour
{

    public void ChangeScene(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void ChangeSceneRandom()
    {
        int valorRandom = (int) (Random.Range(0 , 99) + 1);

        string nombreEscena = "";

        
        if(valorRandom >= 0 && valorRandom <= 30) 
            nombreEscena = "VideoScene";

        if (valorRandom >= 31 && valorRandom <= 60)
            nombreEscena = "QuienEsCharly";

        if (valorRandom >= 61 && valorRandom <= 100)
            nombreEscena = "QuienEsMarley";
        

        SceneManager.LoadScene(nombreEscena);
    }


    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }



}
