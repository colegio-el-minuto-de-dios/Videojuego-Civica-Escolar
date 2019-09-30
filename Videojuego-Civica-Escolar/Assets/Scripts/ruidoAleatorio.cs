using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruidoAleatorio : MonoBehaviour
{
    public List<float> listaNumeros = new List<float>();
    
    public float numeroGenerado;
    public GameObject origenRuidoUno;
    public GameObject origenRuidoDos;
    public GameObject origenRuidoTres;
    public GameObject origenRuidoCuatro;
    
    // Start is called before the first frame update
    void Start()
    {
        AparicionAleatoria();        
    }
    
    public void AparicionAleatoria(){
        
        if((listaNumeros.Count) <5){
            numeroGenerado = Random.Range(1,5);
            if(listaNumeros.Contains(numeroGenerado)){
                AparicionAleatoria();
            }
            else{
                listaNumeros.Add(numeroGenerado);
                switch (numeroGenerado){
                    case 1:
                    origenRuidoUno.SetActive(true);
                    break;
                    case 2:
                    origenRuidoDos.SetActive(true);
                    break;
                    case 3:
                    origenRuidoTres.SetActive(true);
                    break;
                    case 4:
                    origenRuidoCuatro.SetActive(true);
                    break;
                    
                }
            }

        }       
        
    }
}
