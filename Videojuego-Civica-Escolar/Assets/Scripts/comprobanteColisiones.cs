using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class comprobanteColisiones : MonoBehaviour
{
    public float temporizador = 0f;
    public GameObject NPC;
    public bool enFila = false;
    
    
    void Start(){
        NPC.GetComponent<seguirjugador>().enabled = false;
        NPC.GetComponent<caminataAleatoria>().enabled = true;
        enFila = false;
    }

    
    void OnTriggerEnter(Collider other){
        if(other.tag =="Player"){
            NPC.GetComponent<seguirjugador>().enabled = true;
            NPC.GetComponent<caminataAleatoria>().enabled = false;
        }
        if(other.name == "Fila"){
            temporizador = 0;
            enFila = true;
            contadorPersonasFilas.contador += 1;
        }
            
    }

    void OnTriggerExit(Collider other){
        if(other.name == "Fila"){
            temporizador = 0;
            enFila = false;
            contadorPersonasFilas.contador -= 1;
        }
        if(other.tag == "Player"){
            NPC.GetComponent<seguirjugador>().enabled = false;
            NPC.GetComponent<caminataAleatoria>().enabled = true;
        }

    }

    void OnTriggerExit(){
        NPC.GetComponent<seguirjugador>().enabled = false;
        NPC.GetComponent<caminataAleatoria>().enabled = true;
    }

    void Update(){
        if(enFila == true){
            temporizador += Time.deltaTime; 
            NPC.GetComponent<seguirjugador>().enabled = false;
            NPC.GetComponent<caminataAleatoria>().enabled = false;
            if(temporizador >= 20){
                enFila = false;
                temporizador = 0;
                NPC.GetComponent<caminataAleatoria>().enabled = true;
            }
        }
    }
}
