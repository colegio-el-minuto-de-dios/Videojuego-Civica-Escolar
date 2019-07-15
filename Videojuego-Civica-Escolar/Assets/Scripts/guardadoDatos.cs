using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;  
using System;
using System.Text;
using TMPro;
using UnityEngine.UI;

public class guardadoDatos : MonoBehaviour
{
    public TMP_InputField cuadroNombre;
    public TMP_InputField cuadroContraseña;
    public static string nombre;
    public static string contraseña;
    public Toggle hombreCheck;
    public Toggle mujerCheck;
    public static string genero;
    public TextMeshProUGUI testigo;
    static string rellenoJSON;

    // Start is called before the first frame update
    void Start()
    {
        testigo.text = "".ToString();                        
    }

    public void recibirDatos(){

        if (hombreCheck.isOn != true){
            genero = "mujer";
        }
        else{
            genero = "hombre";
        }

        //verificar si hay algo en el nombre
        if (cuadroNombre != null){
            nombre = cuadroNombre.text;
            contraseña = cuadroContraseña.text;  
            crearArchivo();    
            print(nombre);
   
        }      
    }
    public static void crearArchivo() 
    {
        rellenoJSON = ("{\n  \"personaje\": [\n    {\"Item\": \"Contraseña\", \"Dato\": \""+ contraseña +"\"},\n    {\"Item\": \"Genero\", \"Dato\": \""+ genero + "\"},\n    {\"Item\": \"Piezas\", \"Dato\": \"\"}\n  ],\n  \"niveles\": [\n    {\"Isla\": \"Uno\", \"misionUno\": \"No\", \"misionDos\": \"No\" },\n    {\"Isla\": \"Dos\", \"misionUno\": \"No\", \"misionDos\": \"No\" },\n    {\"Isla\": \"Tres\", \"misionUno\": \"No\", \"misionDos\": \"No\" },\n    {\"Isla\": \"Cuatro\", \"misionUno\": \"No\", \"misionDos\": \"No\" },\n    {\"Isla\": \"Cinco\", \"misionUno\": \"No\", \"misionDos\": \"No\" }\n  ],\n  \"nivelesEspeciales\":[\n    {\"Mision\": \"Tutorial\", \"estado\": \"No\"},\n    {\"Mision\": \"BossFinal\", \"estado\": \"No\"}\n  ]\n}");
        Debug.Log(nombre);
        string path = (nombre+".json");

        //Si el archivo existe, usar funcion de cargar partida
        if (File.Exists(path)) 
        {
            return;                                
        }
        else{
            using (FileStream fs = File.Create(path, 1024)) 
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(guardadoDatos.rellenoJSON);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

    }
}

