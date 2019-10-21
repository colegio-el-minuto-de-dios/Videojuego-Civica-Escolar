using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arosReciclaje : MonoBehaviour
{
    public string tipoDesecho;
    public static string aroSeleccionado;
    public ParticleSystem explosion;
    void Start(){
        aroSeleccionado = "";
    }
    void OnTriggerEnter(Collider other){
        if(other.name == "NarizMisil"){
            explosion.Play();
        }
        if(other.name != "Misil"){
            if (other.GetComponent<residuos>().tipoBasura == tipoDesecho){
            Destroy(other.gameObject);
            contadorReciclaje.reciclajeCorrecto += 1;
        }
        else{
            other.GetComponent<residuos>().coincidencia = "no";
        }
        }
        
        
    }

    void OnTriggerExit(Collider other){
        if(other.name != "Misil"){
        other.GetComponent<residuos>().coincidencia = "no";
        }
    }

    void OnMouseDown() {
        aroSeleccionado = gameObject.name;
        print(aroSeleccionado);

        
    }
}
