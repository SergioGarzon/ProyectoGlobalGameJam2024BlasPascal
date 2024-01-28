using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneButtonEditor : MonoBehaviour
{
    public Image[] imgButton;
    public Sprite[] spriteImgButton;
    private int accion;

    void Start()
    {
        accion = 0;
    }

    public void setearImagen(int accion)
    {
        if(accion == 1)
        {
            StartCoroutine(CorrutinaCambiarEscena());
        } 
        
    }

    IEnumerator CorrutinaCambiarEscena()
    {
        yield return new WaitForSeconds(0.1f);

        imgButton[0].sprite = spriteImgButton[0];

        yield return new WaitForSeconds(0.1f);

        imgButton[0].sprite = spriteImgButton[1];

        yield return new WaitForSeconds(0.1f);

        SceneManager.LoadScene(0);
    }


}
