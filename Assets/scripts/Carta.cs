using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
  
  public Manager manager;
  public Animator animator;

   void OnMouseUpAsButton()
    {
      
      
       
       manager.RecibirCarta(this);


    }
  
}
