using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesAdicionales : MonoBehaviour
{
    
    public Animator anim;
    public static bool haPerdido =false; 
    public bool colisionMuro;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();  
        colisionMuro =false;
        haPerdido =false; 
    }

    // Update is called once per frame

    void Update(){
        
        if((colisionMuro == true) && (Input.GetKey(KeyCode.Space))){
            colisionMuro = false;
            anim.Play("Jump");
        }
        if((colisionMuro == true) && !(Input.GetKey(KeyCode.Space) )){
            anim.SetBool("forzarEstatico",true);  
            controlPersonaje.velocidadCaminar = 0.01f;
            controlPersonaje.velocidadCorrer = 0.01f; 
        }
        if(colisionMuro == false){
            anim.SetBool("forzarEstatico",false); 
            controlPersonaje.velocidadCaminar = 2f;
            controlPersonaje.velocidadCorrer = 5f;             
        }

    }

    void OnTriggerEnter(Collider other) {
        if((other.tag != "Player") && (other.tag != "Respawn") && (other.tag != "Pasivo")){
            colisionMuro = true;
        }
        if(other.tag == "Respawn"){
            colisionMuro = false;
        }
                
    }    

    void OnTriggerExit(Collider other) {
        colisionMuro = false;        
    }

    public void HaPerdido(){
        if(haPerdido == true){
            anim.Play("Perdida");  
        }
        if(haPerdido == false){
            anim.SetBool("haPerdido",false);  
        }
    }
     
    
}