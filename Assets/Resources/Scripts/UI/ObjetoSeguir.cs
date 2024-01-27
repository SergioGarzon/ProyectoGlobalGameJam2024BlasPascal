using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoSeguir : MonoBehaviour
{
    public Transform objetoOrigen; // Asigna el objeto cuya posición quieres copiar
    public Transform objetoDestino; // Asigna el objeto al que quieres asignar la posición

    void Update()
    {
        if (objetoOrigen != null && objetoDestino != null)
        {
            // Copia la posición del objetoOrigen al objetoDestino
            objetoDestino.position = objetoOrigen.position;
        }
    }
}
