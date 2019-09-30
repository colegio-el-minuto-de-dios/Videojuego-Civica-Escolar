using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelesCorrectos : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
