﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celebración : MonoBehaviour
{
    public GameObject fuegosArtificiales;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){    
            fuegosArtificiales.SetActive(true);        
            
        }
    }

}
