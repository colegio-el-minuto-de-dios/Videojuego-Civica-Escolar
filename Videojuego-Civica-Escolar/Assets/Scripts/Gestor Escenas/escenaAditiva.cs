using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenaAditiva : MonoBehaviour
{   
    public string nombreEscena;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            SceneManager.LoadScene(nombreEscena, LoadSceneMode.Additive);           
            
        }
        
    }

    void OnTriggerExit(Collider other){
        if (other.tag == "Player"){
            SceneManager.UnloadScene("OrganizarPartituras");   
            print("BUDDY SE FUE XD");
        }

    }
}
