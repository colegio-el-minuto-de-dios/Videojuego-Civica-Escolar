using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject jugador;
    void  OnTriggerEnter ( Collider col  ){
        if(col.tag =="Player"){
            jugador.GetComponent<controlPersonaje>().enabled=false;
            jugador.transform.position = spawnPoint.position;
        }
    }
}