using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarAnimacion : MonoBehaviour
{
    private Animator animation;

    private int valorDefecto;

    public void Start()
    {
        animation = GetComponent<Animator>();

        valorDefecto = 0;
    }

    public void ActivarAnimacion()
    {
        if(valorDefecto == 0)
        {
            animation.SetBool("ActivarAnimacion", true);
            valorDefecto = 1;
        } else
        {
            animation.SetBool("ActivarAnimacion", false);
            valorDefecto = 0;
        }             
       
    }



}
