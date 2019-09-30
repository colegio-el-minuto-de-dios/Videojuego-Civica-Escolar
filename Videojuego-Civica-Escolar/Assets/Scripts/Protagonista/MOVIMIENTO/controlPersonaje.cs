using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{
    public static float velocidadCaminar = 2;
    public static float velocidadCorrer = 5;
    public float movimientoHorizontal;
    public float movimientoVertical;
    public float fuerzaSalto;
    public float gravedad;
    private Vector3 controlJugador;
    public CharacterController jugador;
    private Vector3 ejeJugador;
    public float velocidadCaida;
    public Animator anim;
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    public static string colisionCajasInformativas;

    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        
        
    }      

    // Update is called once per frame
    void Update()
    {
        while (anim == false){
            anim = GetComponentInChildren<Animator>();
            
        }

        /*if(indicacionesTurorial.colision == true){
            anim.SetBool("forzarEstatico", true);
        } */

        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");    

        controlJugador = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        controlJugador = Vector3.ClampMagnitude(controlJugador,1);

        direccionCamara();

        ejeJugador = controlJugador.x * camRight + controlJugador.z * camForward;

        if((Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
            ejeJugador = ejeJugador * velocidadCorrer;
            anim.SetBool("estaCorriendo",  true);
        }
        else
        {
            anim.SetBool("estaCorriendo", false);
        }

        if((Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D)) && !Input.GetKey(KeyCode.LeftShift))
        {
            ejeJugador = ejeJugador * velocidadCaminar;
            anim.SetBool("estaCorriendo", false);
            anim.SetBool("estaCaminando", true);
        }
        else{
            anim.SetBool("estaCaminando", false);
        }
        
        
        jugador.transform.LookAt(jugador.transform.position + ejeJugador);

        establecerGravedad();

        saltoJugador();

        jugador.Move(ejeJugador * Time.deltaTime);
    }

    void saltoJugador()
    {
        if (jugador.isGrounded && Input.GetButtonDown("Jump"))
        {
            velocidadCaida = fuerzaSalto;
            ejeJugador.y = velocidadCaida;

            anim.SetTrigger("estaSaltando");
        }
    }

    void establecerGravedad()
    {
        if(jugador.isGrounded)
        {
            velocidadCaida = -gravedad * Time.deltaTime;
            ejeJugador.y = velocidadCaida;
            anim.SetBool("enSuelo", true);
        }
        else
        {
            velocidadCaida -= gravedad * Time.deltaTime;
            ejeJugador.y = velocidadCaida;
            anim.SetBool("enSuelo", false);
        }

        
    }
    void direccionCamara()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    } 

          
}
