using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gestorDatos : MonoBehaviour
{
    [Header("Carga de personajes según fichero de partida")]
	[Space(5)]	
    public GameObject personajeMujer;
    public GameObject personajeHombre;
    public GameObject jugador;
   
    

    // Start is called before the first frame update
    void Start()
    {
        if(leerDatos.genero == "mujer"){
            
            Destroy(personajeHombre);            
        }   
        if(leerDatos.genero == "hombre"){
             
            Destroy(personajeMujer);            
        }
        jugador.GetComponent<controlPersonaje>().enabled=true;
                          
    }

}

