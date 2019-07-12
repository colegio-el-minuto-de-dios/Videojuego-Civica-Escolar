using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionMuro : MonoBehaviour
{
    [SerializeField] private Animator anim;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Pasivo")) {
            anim.Play("IDLE"); 
            
            }
    }

    void OnTriggerStay(Collider other) {
        if (other.CompareTag("Pasivo")) {
            anim.Play("IDLE");
            
            
            }
    }



    

}
