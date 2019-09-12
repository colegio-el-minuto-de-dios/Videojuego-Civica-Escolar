using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contadorPersonasFilas : MonoBehaviour
{
    public TextMeshProUGUI contadorGUI;
    public static float contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        contadorGUI.text = contador.ToString();
    }


    
}
