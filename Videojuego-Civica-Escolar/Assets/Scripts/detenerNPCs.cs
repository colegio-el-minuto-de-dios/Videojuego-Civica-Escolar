using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detenerNPCs : MonoBehaviour
{
    public GameObject NPC; 
    public float temporizador;
    

    void OnTriggerEnter(Collider other){
        if (other.tag == "NPC")  {
            NPC.GetComponent<seguirjugador>().enabled = false;
            NPC.GetComponent<caminataAleatoria>().enabled = false;
            
        }     
    }  
}
