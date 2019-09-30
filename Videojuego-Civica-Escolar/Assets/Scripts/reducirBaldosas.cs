using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reducirBaldosas : MonoBehaviour
{
    
    public float temporizador;
    public float tamañoXZ =335;
    public float tamañoY = 135;
    public bool estaPisando =false ;
    // Start is called before the first frame update
    void Start()
    {
      temporizador = 0;  
      estaPisando = false;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            temporizador = 0;
            estaPisando = true;
            //transform.localScale += new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if(estaPisando == true){
            temporizador += Time.deltaTime;
            tamañoXZ = -111.6f * (temporizador) + 335;
            tamañoY = -45f * (temporizador) + 135;
            transform.localScale = new Vector3(tamañoXZ, tamañoY, tamañoXZ);
            if(temporizador > 3){
                estaPisando = false;
            }
        }        
    }
}
