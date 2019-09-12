using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organizarPartituras : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {
        if (gameObject.name == "P1-H"){
            if(other.name == "P1"){
                contadorPartituras.numeroPartituras += 1;
            }
        }  
        if (gameObject.name == "P2-H"){
            if(other.name == "P2"){
                contadorPartituras.numeroPartituras += 1;
            }
        }  
        if (gameObject.name == "P3-H"){
            if(other.name == "P3"){
                contadorPartituras.numeroPartituras += 1;
            }
        }  
        if (gameObject.name == "V1-H"){
            if(other.name == "V1"){
                contadorPartituras.numeroPartituras += 1;
            }
        }  
        if (gameObject.name == "V2-H"){
            if(other.name == "V2"){
                contadorPartituras.numeroPartituras += 1;
            }
        }  
        if (gameObject.name == "V3-H"){
            if(other.name == "V3"){
                contadorPartituras.numeroPartituras += 1;
            }
        }        
    }

    void OnTriggerExit(Collider other) {
        if (gameObject.name == "P1-H"){
            if(other.name == "P1"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }  
        if (gameObject.name == "P2-H"){
            if(other.name == "P2"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }  
        if (gameObject.name == "P3-H"){
            if(other.name == "P3"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }  
        if (gameObject.name == "V1-H"){
            if(other.name == "V1"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }  
        if (gameObject.name == "V2-H"){
            if(other.name == "V2"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }  
        if (gameObject.name == "V3-H"){
            if(other.name == "V3"){
                contadorPartituras.numeroPartituras -= 1;
            }
        }
        
    }


}