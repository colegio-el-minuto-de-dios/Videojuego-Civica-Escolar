using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorCapturados : MonoBehaviour
{
    public static int numeroCapturados;
    // Start is called before the first frame update
    void Start()
    {
        numeroCapturados = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(numeroCapturados){
            case 3:
            print("EL AMO DE LOS AMOS");
            break;
            case 2:
            print("EL AMO DE LOS SEÑORES");
            break;
            case 1:
            print("EL AMO DE LOS PERRITOS");
            break;
            case 0:
            print("EL AMO DE LA MUGRE XD");
            break;
        }
        
    }
}
