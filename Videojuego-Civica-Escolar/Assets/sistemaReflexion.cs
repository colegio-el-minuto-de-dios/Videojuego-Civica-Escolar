using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemaReflexion : MonoBehaviour
{
    [Header("Selecciona el puntaje necesario")]  
    public static float puntajeActual;
    public float puntajeNecesario;
    [Header("Primer contenedor")]  
    public GameObject fadeOutHUD; 
    public GameObject jugadorA;
    [Header("Selecciona los animadores")]   
    [Header("Segundo contenedor")]       
    public Animator enemigoAnim;     
    public Animator residenteAnim;  
    [Header("Interfaces y elementos")]      
    public GameObject primerContenedor;
    public GameObject segundoContenedor;
    public GameObject jugador;    
    public GameObject interfazReflexion;   
    public GameObject reflexionFadeOut;
    public GameObject medallaPremio;
    public GameObject reflexiones;

    private bool activarTemporizador;
    private float timmer;
    

    // Start is called before the first frame update
    void Start()
    {
        puntajeActual = 0f;    
        timmer = 0f;   
        jugador.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(activarTemporizador == true){
            timmer += Time.deltaTime;
            if((timmer > 1f)&&(timmer <1.5f)){
                segundoContenedor.SetActive(true);
                Destroy(primerContenedor);                
                enemigoAnim.SetBool("estaEscuchando",true);
                activarTemporizador = false;
            }
        }
        if(puntajeActual == puntajeNecesario){
            AbrirInterfazReflexion();
        }        
    }


/////////////////////////////////////////////////////////////////////////////////////////////////
    void Temporizador(){
        timmer = 0;
        activarTemporizador = true;   
    }    

    public void AbrirInterfazReflexion(){ 
        jugadorA.GetComponent<controlPersonaje>().enabled=false;
        fadeOutHUD.SetActive(true);    
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;     
        puntajeActual += 1;        
        Temporizador(); 
        
        
    }

    public void SeleccionarReflexion(){        
        //enemigoAnim.SetBool("estaAceptando",true);
        Destroy(reflexiones);
    }

    public void TerminarReflexion(){        
        //enemigoAnim.SetBool("estaFeliz", true);
        residenteAnim.SetBool("estaAplaudiendo",true);  
        interfazReflexion.SetActive(false);
        jugador.SetActive(true);
        
    }



}
