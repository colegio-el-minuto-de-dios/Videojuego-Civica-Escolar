using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class residuos : MonoBehaviour
{
    
    public Transform puntoOrigen;
    public Transform misil;
    public string clic = "no";
    public float speed;
    public string tipoBasura;
    public string coincidencia;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (clic == "si"){
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, misil.position, step);             
                 
        }  

        if (contadorReciclaje.itemsMisil >3){
            transform.position = puntoOrigen.position; 
            transform.parent = null;  
        }
        

        if (coincidencia == "no"){
            transform.parent = null;   
            transform.position = puntoOrigen.position;              
            coincidencia ="";
            
        } 
        
    }

    void OnTriggerEnter(Collider other){
        if(other.name == "Misil"){
        
        transform.position = misil.position;
        transform.parent = misil.transform; 
        clic = "no";
        contadorReciclaje.itemsMisil +=1;
        
        }
        if (contadorReciclaje.itemsMisil >3){
            transform.position = puntoOrigen.position; 
            transform.parent = null;  
        }
    }

    void OnMouseDown(){
        if(contadorReciclaje.itemsMisil <3){
           clic = "si"; 
        }
               
    }
}
