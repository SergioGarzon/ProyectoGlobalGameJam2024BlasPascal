using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRuleta : MonoBehaviour
{

    private bool startRotate;
    private int valor;

    public int speed;

    public void Start()
    {
        startRotate = false;
        valor = 0;
    }

    public void Update()
    {
        if(startRotate)
            transform.Rotate(0, 0, (speed * Time.deltaTime) * (-1));
    }

    public void setStartRotate()
    {
        if (valor == 0)
        {
            startRotate = true;
            valor = 1;
        }
        else
        {
            startRotate = false;
            valor = 0;
        }        
    }

    
}
