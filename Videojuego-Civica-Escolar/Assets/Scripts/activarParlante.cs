using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarParlante : MonoBehaviour
{
    public GameObject ruidoAleatorio;
    public GameObject parlante;
    public string haTocado = "No";
    // Start is called before the first frame update
    void Start(){
        haTocado ="No";
    }
    

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if((other.tag == "Player") && (haTocado == "No")){
            haTocado = "Si";
            if(haTocado ==  "Si"){
                parlante.GetComponent<AudioSource>().Stop();
                ruidoAleatorio.GetComponent<ruidoAleatorio>().AparicionAleatoria();  
                ruidoAleatorio.GetComponent<ruidoAleatorio>().enabled = false;
                haTocado = "Hecho";
            }
            
        }
          
    }

    void OnTriggerExit(){
        ruidoAleatorio.GetComponent<ruidoAleatorio>().enabled = true;
    }
}
