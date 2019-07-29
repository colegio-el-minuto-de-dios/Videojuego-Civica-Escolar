using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject jugador;
    public static Vector3 posicion;
    public static Transform spawnPointTranslation;

    
    void  OnTriggerEnter ( Collider col  ){
        if(col.tag == "Player"){
            jugador.GetComponent<controlPersonaje>().enabled=true;
            posicion = GameObject.Find("SpawnPoint").transform.position;            
            print("posicion " + posicion);
        }
    }
}