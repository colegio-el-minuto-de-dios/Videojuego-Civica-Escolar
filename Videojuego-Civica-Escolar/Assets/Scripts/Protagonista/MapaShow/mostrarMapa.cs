using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarMapa : MonoBehaviour
{
    public GameObject mapa;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab)){
            mapa.SetActive(true);
        }
        else{
            mapa.SetActive(false);
        }

        
    }
}
