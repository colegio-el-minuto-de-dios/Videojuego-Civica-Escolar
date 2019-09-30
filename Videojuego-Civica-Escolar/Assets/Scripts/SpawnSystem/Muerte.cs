using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject jugador;
    public float tiempoReaparecer;
    public bool haMuerto = false;

    void Start(){
        spawnPoint = GameObject.Find("SpawnPoint").transform;
        jugador = GameObject.Find("Contenedor personajes");
        haMuerto =false;
        tiempoReaparecer = 0f;
        AnimacionesAdicionales.haPerdido = false;
    }
    void  OnTriggerEnter (Collider col  ){
        if(col.tag =="Player"){
            tiempoReaparecer = 0f;
            
            AnimacionesAdicionales.haPerdido = true;
            jugador.GetComponent<AnimacionesAdicionales>().HaPerdido();
            jugador.GetComponent<controlPersonaje>().enabled=false;  
            haMuerto = true;       
            
            
        }
        
    }

    void  OnTriggerExit (Collider col  ){
        if(col.tag =="Player"){
            AnimacionesAdicionales.haPerdido = false;
            jugador.GetComponent<AnimacionesAdicionales>().HaPerdido();   
                   
            
        }
    }

    void Update(){
        if(tiempoReaparecer >= 2.6f){
            tiempoReaparecer=0;
            haMuerto = false;
        }

        if(haMuerto == true){
            tiempoReaparecer += Time.deltaTime;
            if((tiempoReaparecer >= 1.5f)  && (tiempoReaparecer < 2.6f)){
                jugador.transform.position = spawnPoint.position;                
                haMuerto = false;
            }
            
            
        }
    }
}