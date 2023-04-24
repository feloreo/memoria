using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
  public Carta carta1=null;
  public Carta carta2=null;
  public GameObject cartas;
  public GameObject inactivas;
   

    // Update is called once per frame
    public void RecibirCarta(Carta c)
    {
       
                if (carta1 == null){
                    carta1 = c;
                    carta1.GetComponent<Collider>().enabled = !carta1.GetComponent<Collider>().enabled;
                    return;}
        

                else if (carta2==null){
                 carta2 = c;  
                 carta2.GetComponent<Collider>().enabled = !carta2.GetComponent<Collider>().enabled;      
            }
        if(carta1.tag==carta2.tag){
            
            carta1.transform.parent=inactivas.transform;
            carta2.transform.parent=inactivas.transform;
            carta1=null;
            carta2=null;
        }
        else{
                Debug.Log("NO!");
                carta1.GetComponent<Collider>().enabled = !carta1.GetComponent<Collider>().enabled;
                carta2.GetComponent<Collider>().enabled = !carta2.GetComponent<Collider>().enabled; 
                carta1=null;
                carta2=null;
                
            }
    }
}
