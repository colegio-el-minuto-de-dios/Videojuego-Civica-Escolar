using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirjugador : MonoBehaviour {
    public Transform jugador;
    UnityEngine.AI.NavMeshAgent enemigo;
    private bool dentro = false;
    float distancia;
    public GameObject jugadorGO;
    public Animator anim;

	// Use this for initialization
	void Start () {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dentro = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3.5f;
            dentro = false;
        }
    }
	// Update is called once per frame
	void Update () {
		
        if (!dentro)
        { 
            print("Distancia" + distancia);
            
            enemigo.destination = jugador.position;
            distancia = Vector3.Distance(transform.position, jugadorGO.transform.position);
            if ((distancia < 1.5f) | (distancia >= 3f)){
                GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3.5f;
            }
            if ((distancia >= 1.5f) & (distancia < 3f)){
                GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 6.5f;
            }
            
        }
        if (dentro)
        {
            enemigo.destination = this.transform.position;
        }
        
	}
}
