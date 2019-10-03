using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMinijuegoMemoria : MonoBehaviour
{
    public GameObject cubos;
    public GameObject instruccion;
    public GameObject camaraA;
    public GameObject camaraB;
    // Start is called before the first frame update
    void Start()
    {
        cubos.SetActive(false);
        instruccion.SetActive(false);  
        camaraA.SetActive(false);
        camaraB.SetActive(false);       
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            cubos.SetActive(true);
            instruccion.SetActive(true); 
            if(gameObject.name == "Cubo A"){                   
                camaraA.SetActive(true);                 
            }
            if(gameObject.name == "Cubo B"){                   
                camaraB.SetActive(true);                 
            }
        }
    }

    void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            cubos.SetActive(false);
            instruccion.SetActive(false);  
            camaraA.SetActive(false);
            camaraB.SetActive(false);  
        }
    }
}
