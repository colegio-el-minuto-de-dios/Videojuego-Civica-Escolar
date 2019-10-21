using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;  
using System;
using System.Text;

public class seleccionarIsla : MonoBehaviour
{
    public string isla;
    public static string jsonString;
    public static string estadoIsla;
    [TextArea]
    public string informacionCuadro;
    public Animator cuadroInformativo;
    public TextMeshProUGUI informacionTMP;
    public GameObject nubeMaldad;
    // Start is called before the first frame update
    void Start()
    {
        estadoIsla = isla; 

        jsonString = File.ReadAllText(leerDatos.archivo);   
        datosJugador infoJugador = JsonUtility.FromJson<datosJugador>(jsonString);  
        string estado = (infoJugador.niveles.Find(p => p.Isla == estadoIsla).misionUno).ToString();    
        if(estado != "No"){
            nubeMaldad.SetActive(false);
        }    
    }
    
    void OnMouseDown(){
        iniciarIsla.prepararEscena = isla;
        informacionTMP.text =  informacionCuadro;    
        cuadroInformativo.SetBool("CuadroTextoAbierto", true);   
        
    }
    

    
}
