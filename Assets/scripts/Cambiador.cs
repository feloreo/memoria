using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiador : MonoBehaviour
{

public Animator animator;
public float tiempo;
public bool iniciar = false;

void Start(){
    iniciar=false;
}
    void Update(){
        if (iniciar){
            tiempo-=Time.deltaTime;}
        if(tiempo<=0){
            SceneManager.LoadScene(1);
        
        }
    }


    public void CambiarEscena(){
        iniciar=true;
        
    }
}
