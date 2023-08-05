using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swamping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Randomizar(); 
    }

    void Swamp(GameObject cartaA, GameObject cartaB){
        Vector3 posA= cartaA.transform.position;
        Vector3 posB= cartaB. transform.position;
        cartaB. transform.position= posA;
        cartaA. transform.position= posB;
    }

    public List <GameObject> cartas;
    void Randomizar(){
        foreach (GameObject carta in cartas){
            int random = Random.Range(0,cartas.Count);
            Swamp(carta,cartas[random]);
        }
    }
}
