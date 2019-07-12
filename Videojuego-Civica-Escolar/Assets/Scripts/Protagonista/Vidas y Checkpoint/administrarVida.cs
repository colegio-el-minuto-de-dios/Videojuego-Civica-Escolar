using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarVida : MonoBehaviour
{
    public int daño;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            sistemaVidas.salud -= daño;
            print("te ha quitado vida ese desgraciado");
        }
        
    }

}
