using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victoria : MonoBehaviour
{
   
 public float parejasActuales = 0;
 public float tiempoDisfrute= 3;
    public GameObject victoria;
    public Text visorPuntaje;
    public Text visorPuntajeDerrota;
public float puntosSumar;
public Puntuacion puntaje;
public GameObject tiempo;

    void Update()
    {
        
        if (parejasActuales ==6){
            tiempoDisfrute-=Time.deltaTime;
            tiempo.SetActive(false);
        }
        if (tiempoDisfrute<=0){
            victoria.SetActive(true);
        }

        visorPuntaje.text = ((int)puntaje.puntajeTotal).ToString();
        visorPuntajeDerrota.text = ((int)puntaje.puntajeTotal).ToString();
       
        {

            

        }

    }
    public void GanarXPuntos(){
       parejasActuales+=1;
    }
}
