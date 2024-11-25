using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text textoPuntaje;
    private int puntaje = 0;

    public void IncrementarPuntaje(int cantidad)
    {
        puntaje += cantidad;
        ActualizarTextoPuntaje();
    }

    void ActualizarTextoPuntaje()
    {
        textoPuntaje.text = "Puntuación: " + puntaje.ToString();
    }
}
