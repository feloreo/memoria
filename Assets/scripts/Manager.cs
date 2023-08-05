using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
  public Carta carta1=null;
  public Carta carta2=null;
  public GameObject cartas;
  public GameObject inactivas;
  public CuentaRegresiva tiempo;
  public float sumarTiempo;
  public Puntuacion puntaje;
  public Victoria pareja;
  public bool corutina;
  public float corutinaTime = .5f;
  public Animator daño;

 
   

    // Update is called once per frame
    public void RecibirCarta(Carta c)
    {
       
        if (carta1 == null){
                carta1 = c;
                
                carta1.GetComponent<Collider>().enabled = !carta1.GetComponent<Collider>().enabled;
                carta1.animator.SetTrigger("seleccion");
                return;
        }
        else if (carta2==null){
            carta2 = c;  
            carta2.GetComponent<Collider>().enabled = !carta2.GetComponent<Collider>().enabled;
            carta2.animator.SetTrigger("seleccion");      
        }
        if(carta1.tag==carta2.tag){
            
            carta1.transform.parent=inactivas.transform;
            carta2.transform.parent=inactivas.transform;
            carta1=null;
            carta2=null;
            

            tiempo.tiempoTotal+=sumarTiempo;
            puntaje.GanarPuntos();
            pareja.GanarXPuntos();


        }
        else{
            tiempo.tiempoTotal-= sumarTiempo;
            daño.SetTrigger("hit");
                if (!corutina){
                     StartCoroutine(Fade());
                }
                
            }
    }
    IEnumerator Fade()
{
    corutina= true;
        yield return new WaitForSeconds(corutinaTime);
        Debug.Log("NO!");
        //tiempo.tiempoTotal-= sumarTiempo;
        carta1.animator.SetTrigger("look"); 
        carta2.animator.SetTrigger("look");
        carta1.GetComponent<Collider>().enabled = !carta1.GetComponent<Collider>().enabled;
        carta2.GetComponent<Collider>().enabled = !carta2.GetComponent<Collider>().enabled; 
        carta1=null;
        carta2=null;
        corutina=false;
    }

}
