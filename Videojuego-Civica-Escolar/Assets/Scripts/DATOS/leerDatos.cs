using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;  
using System;
using System.Text;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leerDatos : MonoBehaviour
{
    public TMP_InputField cuadroNombre;
    public TMP_InputField cuadroContraseña;
    public TextMeshProUGUI testigo;
    public static string nombre;
    public static string contraseña;
    public static string genero; 
    public static string tutorial;
    public static string jsonString;
    public static string archivo;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Main Menu"){
            testigo.text = "".ToString();   
        }
                             
    }
    public void iniciarPartida(){
        //verificar si hay algo en el nombre
        if (cuadroNombre.text != null){
            nombre = cuadroNombre.text;
            contraseña = cuadroContraseña.text;    
            recuperarDatos();
            print("Ejecución terminada"); 
            cuadroNombre.text = "".ToString();
            cuadroContraseña.text = "".ToString();
            print(nombre);
        }  
        else if(cuadroNombre.text == ""){
            testigo.text = "Ingresa un nombre válido".ToString();  
        }        
  
    }

    public void recuperarDatos(){
        // Verificar si el archivo existe
        archivo = (nombre+".json");
        if (File.Exists(archivo)) 
        {
            // Abrir archivo JSON
            /* 
            string jsonString = File.ReadAllText(archivo);   
            datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
            Debug.Log("En ejecucion");
            infoJugador.personaje.Find(p => p.Item == "Contraseña").Dato = "DatoCambiado";
            jsonString = JsonUtility.ToJson(infoJugador);
            File.WriteAllText(archivo, jsonString);
            */
            jsonString = File.ReadAllText(archivo);   
            datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);
            // Datos a averiguar
            string contraseñaDat = (infoJugador.personaje.Find(p => p.Item == "Contraseña").Dato).ToString();
            genero = (infoJugador.personaje.Find(p => p.Item == "Genero").Dato).ToString();   
                 

            if(contraseña == contraseñaDat)
            {
                tutorial = (infoJugador.nivelesEspeciales.Find(p => p.Mision == "Tutorial").estado).ToString();
                if (tutorial == "No"){
                    SceneManager.LoadScene("Historia");  
                }
                else{
                    SceneManager.LoadScene("Isla principal");
                }
                              
            }
            else{
                testigo.text = "Contraseña incorrecta".ToString();
            }
       
        }
        else{
            testigo.text = "Esa partida no existe".ToString();            
        }
    }    
}

// Referenciar datos de JSON
[System.Serializable]
public class Personaje {
    public string Item;
    public string Dato;
}

[System.Serializable]
public class Niveles {
    public string Isla;
    public string misionUno;
    public string misionDos;
}

[System.Serializable]
public class NivelesEspeciales {
    public string Mision;
    public string estado;
}

// Recuperar listas
[System.Serializable]
public class datosJugador{
    public List<Personaje> personaje;
    public List<Niveles> niveles;
    public List<NivelesEspeciales> nivelesEspeciales;
}
