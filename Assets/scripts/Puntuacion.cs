using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
 public float puntajeTotal = 0;
    public Text visor;
public CuentaRegresiva tiempo;
public float puntosSumar;

    void Update()
    {
        
        puntosSumar=(tiempo.tiempoTotal/4)*100;

        visor.text = ((int)puntajeTotal).ToString();
        if(puntajeTotal <=0)
        {

            

        }

    }
    public void GanarPuntos(){
        puntajeTotal+=puntosSumar;
    }
}
