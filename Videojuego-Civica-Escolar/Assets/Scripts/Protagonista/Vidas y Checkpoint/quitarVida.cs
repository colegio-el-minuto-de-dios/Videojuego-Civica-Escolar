using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class administrarVida : MonoBehaviour
{
    public int salud;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            sistemaVidas.salud += salud;
            print("te ha quitado vida ese desgraciado");
        }
        
    }

}
