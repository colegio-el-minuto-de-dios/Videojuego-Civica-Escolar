using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparicionBasura : MonoBehaviour
{
    public GameObject basura;
    // Start is called before the first frame update
    void Start()
    {
        basura.SetActive(false);
        
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemigo"){
            basura.SetActive(true);  
        }      
    }
}
