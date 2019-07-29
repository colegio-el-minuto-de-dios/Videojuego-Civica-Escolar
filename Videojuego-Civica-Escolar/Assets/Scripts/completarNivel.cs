using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;  
using System;
using System.Text;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class completarNivel : MonoBehaviour
{
    public static string jsonString = leerDatos.jsonString;
    public static string archivo = leerDatos.archivo;
    public static string datoNivel;
    public static string modificarNivel;
    public string isla;
    public string mision;
    public static string islaActual;
    public static string misionActual;
    public progressIndicator sum;
    public GameObject pieza;

    void Start(){
        islaActual = isla;
        misionActual = mision;
    }
    
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){

            if(misionActual == "misionUno"){
                
                datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
                // Averiguar el dato de las piezas recolectadas en el fichero JSON
                string datoNivel = (infoJugador.niveles.Find(n => n.Isla == islaActual).misionUno).ToString();
                if (datoNivel == "No"){
                    
                    sum.misionUno();                   
                } 
            }

            else if(misionActual == "misionDos"){
                datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
                // Averiguar el dato de las piezas recolectadas en el fichero JSON
                string datoNivel = (infoJugador.niveles.Find(n => n.Isla == islaActual).misionDos).ToString();
                if (datoNivel == "No"){
                    
                    sum.misionDos();              
                } 
            }

            Destroy(pieza);            
        }
    }

    
}
