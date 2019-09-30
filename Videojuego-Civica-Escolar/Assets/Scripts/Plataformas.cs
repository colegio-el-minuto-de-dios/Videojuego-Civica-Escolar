using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public GameObject jugador;
    public GameObject desparentar;
    // Start is called before the first frame update
    void Start()
    {
        jugador= GameObject.Find("Personajes");
        desparentar= GameObject.Find("Jugador");
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            jugador.transform.parent = gameObject.transform;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            jugador.transform.parent = desparentar.transform;
        }
    }
}
