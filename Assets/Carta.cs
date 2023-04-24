using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
  public bool activo = false;
  public Manager manager;

   void OnMouseUpAsButton()
    {
      activo=true;
       Debug.Log("alejandro es un buen amigo");
       manager.RecibirCarta(this);
    }
}
