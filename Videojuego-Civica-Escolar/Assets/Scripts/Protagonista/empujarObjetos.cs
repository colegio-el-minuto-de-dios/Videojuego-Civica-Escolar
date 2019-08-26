using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empujarObjetos : MonoBehaviour
{
    public float fuerzaEmpuje = 2.0f;
    private float masaObjeto;

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody elemento = hit.collider.attachedRigidbody;

        if (elemento == null || elemento.isKinematic){
            return;
        }

        if (hit.moveDirection.y <- 0.3){
            return;
        }

        Vector3 direccionEmpuje = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        elemento.velocity = direccionEmpuje * fuerzaEmpuje / masaObjeto;

        
        
    }
}
  