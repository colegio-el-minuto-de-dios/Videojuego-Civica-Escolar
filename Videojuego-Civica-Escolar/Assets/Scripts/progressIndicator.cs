using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;  
using System;
using System.Text;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class progressIndicator : MonoBehaviour
{
    public TextMeshProUGUI indicadorProgreso;
    public static string datoPiezas;
    public static string datoNivel;
    public static string jsonString = leerDatos.jsonString;
    public static string archivo = leerDatos.archivo;
    
    void Start(){
        mostrarProgreso();         
    }

    public void mostrarProgreso(){        
        // Abrir archivo JSON
        datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
        // Averiguar el dato de las piezas recolectadas en el fichero JSON
        datoPiezas = (infoJugador.personaje.Find(p => p.Item == "Piezas").Dato);   

        // Mostrar las piezas en la GUI
        indicadorProgreso.text = datoPiezas.ToString();        
    }

    public void actualizarProgreso(){
        // Abrir archivo JSON
        datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
        
        // Sumar una unidad a la variable Piezas del JSON
        datoPiezas = infoJugador.personaje.Find(p => p.Item == "Piezas").Dato = (float.Parse(datoPiezas)+1f).ToString();
        jsonString = JsonUtility.ToJson(infoJugador, true);
        File.WriteAllText(archivo, jsonString);    
        

        mostrarProgreso();
    }

    public void misionUno(){
        // Abrir archivo JSON
        datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
        
        // Sumar una unidad a la variable Piezas del JSON
        datoNivel = infoJugador.niveles.Find(p => p.Isla == (completarNivel.islaActual).ToString()).misionUno = ("Si");
        jsonString = JsonUtility.ToJson(infoJugador, true);
        File.WriteAllText(archivo, jsonString);  
        actualizarProgreso();
    }

    public void misionDos(){
        // Abrir archivo JSON
        datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
        
        // Sumar una unidad a la variable Piezas del JSON
        datoNivel = infoJugador.niveles.Find(p => p.Isla == (completarNivel.islaActual).ToString()).misionDos = ("Si");
        jsonString = JsonUtility.ToJson(infoJugador, true);
        File.WriteAllText(archivo, jsonString);  
        actualizarProgreso();
    }

}



