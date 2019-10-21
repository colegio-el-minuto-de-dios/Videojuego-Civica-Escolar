using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarMenu : MonoBehaviour
{

    public bool rotarDerecha;
    public bool rotarIzquierda;
    public Animator cuadroInfromativo;

    // Update is called once per frame
    void Update(){

        if(rotarDerecha == true){
            StartCoroutine(Rotacion(Vector3.up, 72, 1.0f));
            cuadroInfromativo.SetBool("CuadroTextoAbierto", false);
        }

        if(rotarIzquierda == true){
            StartCoroutine(Rotacion(Vector3.up, -72, 1.0f));
            cuadroInfromativo.SetBool("CuadroTextoAbierto", false);
        }
    }

    public void RotacionDerecha(){
        rotarDerecha = true;
    }

    public void RotacionIzquierda(){
        rotarIzquierda = true;
    }

    IEnumerator Rotacion (Vector3 eje, float angulo, float duracion = 1.0f){

        
        
        Quaternion puntoInicial = transform.rotation;
        Quaternion puntoFinal = transform.rotation;

        puntoFinal *= Quaternion.Euler (eje * angulo);

        float tiempoTranscurrido = 0.0f;

        while (tiempoTranscurrido < duracion  && (rotarDerecha | rotarIzquierda)){
            transform.rotation = Quaternion.Slerp(puntoInicial, puntoFinal, tiempoTranscurrido / duracion);
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }

        transform.rotation = puntoFinal;
        rotarDerecha = false;
        rotarIzquierda = false;
    }      
    
}
