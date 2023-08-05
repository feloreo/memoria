using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuentaRegresiva : MonoBehaviour
{
    public float tiempoMaximo;
    public float tiempoTotal;
    public Text visor;
    public Image barra;
    public float tiempoDerrota;
    public GameObject derrota;
    

void Start(){
    tiempoTotal=tiempoMaximo;
}
    void Update()
    {
        tiempoTotal -= Time.deltaTime;
        visor.text = ((int)tiempoTotal).ToString();
        barra.fillAmount = tiempoTotal/tiempoMaximo;

        if(tiempoTotal <=0)
        {
            derrota.SetActive(true);
            tiempoDerrota-=Time.deltaTime;
            if (tiempoDerrota <=0){

                 SceneManager.LoadScene(0);
                }
        }

    }
}
