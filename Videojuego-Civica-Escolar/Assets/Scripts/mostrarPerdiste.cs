using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mostrarPerdiste : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            SceneManager.LoadScene("Pantalla perdiste", LoadSceneMode.Additive);
        }
        
    }
}
