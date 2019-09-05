using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVida : MonoBehaviour
{
    public int salud;
    public float velocidad;
    // Start is called before the first frame update

    void Update(){
        transform.Rotate(new Vector3(0f, velocidad, 0f) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            sistemaVidas.salud += salud;
            Destroy(gameObject);
            print("");
        }
        
    }

}
