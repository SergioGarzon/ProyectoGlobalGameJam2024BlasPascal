using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoSeguir : MonoBehaviour
{
    public Transform objetoOrigen; 
    public Transform objetoDestino; 

    void Update()
    {
        if (objetoOrigen != null && objetoDestino != null)
        {            
            objetoDestino.position = objetoOrigen.position;
        }
    }
}
