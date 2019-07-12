using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeControl : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadCorriendo;
    public float intensidadSalto;
    public CharacterController control;
    public float intensidadGravedad;
    public float velocidadRotacion;
    public Animator anim;    
    private Vector3 direccionMovimiento;
    public Transform pivot;
    
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();                        
    }

    // Update is called once per frame
    void Update()
    {
        float yStore = direccionMovimiento.y;
        direccionMovimiento = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));

        //Para correr: Comprueba que la tecla W se pulsa a la vez que Shift
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            direccionMovimiento = direccionMovimiento.normalized * velocidadCorriendo;
            anim.SetBool("estaCorriendo", true);
        }
        if(Input.GetKey(KeyCode.W) != Input.GetKey(KeyCode.LeftShift))
        {
            direccionMovimiento = direccionMovimiento.normalized * velocidadMovimiento;
            anim.SetBool("estaCorriendo", false);
        }
        
        direccionMovimiento.y = yStore;

        if (control.isGrounded)
        {
            direccionMovimiento.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                direccionMovimiento.y = intensidadSalto;
                anim.SetTrigger("estaSaltando");
            }            
        }

        direccionMovimiento.y = direccionMovimiento.y + (Physics.gravity.y * intensidadGravedad * Time.deltaTime);
        control.Move(direccionMovimiento * Time.deltaTime);

        anim.SetBool("enSuelo", control.isGrounded);
        anim.SetFloat("Velocidad", (Mathf.Abs(Input.GetAxis("Vertical")) +  Mathf.Abs(Input.GetAxis("Horizontal"))));
    }
        

}
