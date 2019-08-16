using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class indicacionesTurorial : MonoBehaviour
{
    void Start(){
        
    }
    public static string archivo = leerDatos.archivo;
    public string texto;
    public TextMeshProUGUI cuadroTexto;
    public GameObject panelTexto;
    public Animator cuadroTextoAnim;
    public GameObject jugador;

    // Cuando colisiona muestra el texto instructivo
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){            
            cuadroTexto.text = texto.ToString();
            cuadroTextoAnim.SetBool("CuadroTextoAbierto",true);  

            if(gameObject.name == "Caminar"){
                jugador.GetComponent<controlPersonaje>().enabled = false;                
                while (!(Input.GetKey(KeyCode.W))){
                    print("OKO");                   
                    cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                    jugador.GetComponent<controlPersonaje>().enabled = true;
                    Destroy(this);                    
                }            
            }

            if(gameObject.name == "Correr"){
                jugador.GetComponent<controlPersonaje>().enabled = false;
                if (Input.GetKey(KeyCode.LeftShift)){
                    cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                    jugador.GetComponent<controlPersonaje>().enabled = true;
                    Destroy(this);
                }     
            }
            if(gameObject.name == "Saltar"){
                jugador.GetComponent<controlPersonaje>().enabled = false;
                if (Input.GetKey(KeyCode.Space)){
                    Destroy(this);
                    cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                    jugador.GetComponent<controlPersonaje>().enabled = true;
                    
                }                    
            }
        }
    }
        
            
 

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player"){
            cuadroTextoAnim.SetBool("CuadroTextoAbierto",false);           
        } 
    }

}

