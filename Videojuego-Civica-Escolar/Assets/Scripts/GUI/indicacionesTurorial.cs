using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class indicacionesTurorial : MonoBehaviour
{

    public static string archivo = leerDatos.archivo;
    public string texto;
    public TextMeshProUGUI cuadroTexto;
    public GameObject panelTexto;
    public Animator cuadroTextoAnim;
    public GameObject jugador;
    public string cubo;
    public float tiempo;

    void Start(){
        Time.timeScale = 1;
    }

    // Cuando colisiona muestra el texto instructivo
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){            
            cuadroTexto.text = texto.ToString();
            cuadroTextoAnim.SetBool("CuadroTextoAbierto",true);  
            

            if(gameObject.name == "Caminar"){
                             
                cubo = "Caminar";         
                }            
            

            if(gameObject.name == "Correr"){
                
                cubo = "Correr";
                }     
            }
            if(gameObject.name == "Saltar"){
                
                cubo = "Saltar";
                    
                }                    
            }
        
    
        
            
 

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player"){
            cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
            if(gameObject.name == "Camara"){
                Destroy(gameObject);
            }
            Time.timeScale = 1;   

        } 
    }

    void Update(){
        if (cubo == "Caminar"){
            Time.timeScale = 1;              
            if (Input.GetKey(KeyCode.W)){
                cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                Time.timeScale = 1;                
                Destroy(gameObject);
                }            
        }
        if (cubo == "Correr"){
            if (tiempo > 3){
                tiempo = 3;
            }
            tiempo -= Time.deltaTime;
            if(tiempo <= 0){
                tiempo = 0;
            }
            Time.timeScale = (tiempo/3);
            
            if ((Input.GetKey(KeyCode.LeftShift))&&(Input.GetKey(KeyCode.LeftShift))){
                cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                Time.timeScale = 1;                  
                Destroy(gameObject);
                }            
        }
        if (cubo == "Saltar"){
            if (tiempo > 3){
                tiempo = 3;
            }
            tiempo -= Time.deltaTime;
            if(tiempo <= 0){
                tiempo = 0;
            }
            Time.timeScale = (tiempo/3);

            if (Input.GetKey(KeyCode.Space)){
                cuadroTextoAnim.SetBool("CuadroTextoAbierto",false); 
                Time.timeScale = 1;                  
                Destroy(gameObject);
                }            
        }
    }

}

