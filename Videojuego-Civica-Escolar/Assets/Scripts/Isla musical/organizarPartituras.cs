using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organizarPartituras : MonoBehaviour
{
    public Vector3 P1;
    public Vector3 P2;
    public Vector3 P3;
    public Vector3 G1;
    public Vector3 G2;
    public Vector3 G3;
    
    void OnTriggerEnter(Collider other) {

        if (other.name == "P1"){      
            P1.Transform.position = gameObject;
        }
        if (other.name == "P2"){      
            P2.Transform.position = gameObject;
        }
        if (other.name == "P3"){      
            P3.Transform.position = gameObject;
        }
        if (other.name == "G1"){      
            G1.Transform.position = gameObject;
        }
        if (other.name == "G2"){      
            G2.Transform.position = gameObject;
        }
        if (other.name == "G3"){      
            G3.Transform.position = gameObject;
        }            
           
    }     
}
