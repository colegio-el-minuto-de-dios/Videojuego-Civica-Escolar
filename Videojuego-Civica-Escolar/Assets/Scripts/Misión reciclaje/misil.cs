using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misil : MonoBehaviour
{
    public Transform puntoOrigen;
    public GameObject puntoOrigenGO;
    public Transform aroOrganicos;
    public Transform aroPlasticos;
    public Transform aroPapel;
    public float speed;
    public bool misilLanzado;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        misilLanzado = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if(misilLanzado == true){
            
            float step = speed * Time.deltaTime;
            if (arosReciclaje.aroSeleccionado == "Plastico"){
                transform.position = Vector3.MoveTowards(transform.position, aroPlasticos.position, step);   
            }
            if (arosReciclaje.aroSeleccionado == "Papel"){
                transform.position = Vector3.MoveTowards(transform.position, aroPapel.position, step);   
            }
            if (arosReciclaje.aroSeleccionado == "Organico"){
                transform.position = Vector3.MoveTowards(transform.position, aroOrganicos.position, step);   
            }

                      
        }        
    }

    void OnTriggerEnter(Collider other){
        if(other.name == "SP-Misil"){
            contadorReciclaje.itemsMisil = 0;            
            puntoOrigenGO.SetActive(false);
            GetComponent<Renderer>().enabled = true;
        }
        if((other.name == "Plastico") | (other.name == "Papel") | (other.name == "Organico")){
            arosReciclaje.aroSeleccionado = null;
            puntoOrigenGO.SetActive(true);            
            contadorReciclaje.itemsMisil = 0;
            transform.position= puntoOrigen.position;
            misilLanzado = false;


        }
    }

    public void LanzarMisil(){
        misilLanzado = true;   
        transform.position = puntoOrigen.position;     
    }
}
