using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class huirIA : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Animator _animator;
    public GameObject Player;
    public float EnemyDistanceRun = 4.0f;
    private BoxCollider detectorCaptura; 
   
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        detectorCaptura = GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        Debug.Log("distancia " + distance);

        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination(newPos);
            _animator.SetBool("estaCorriendo", true);
        }
        else{
            _animator.SetBool("estaCorriendo", false);
        }  
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){            
            _animator.SetTrigger("estaCapturado");
            _animator.SetBool("estaCorriendo", false);
            _agent.enabled = false;
            contadorCapturados.numeroCapturados += 1;
            detectorCaptura.enabled = false;
        }

        
    }
        
    
}
