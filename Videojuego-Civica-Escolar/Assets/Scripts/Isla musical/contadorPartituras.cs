using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class contadorPartituras : MonoBehaviour
{
    public static float numeroPartituras;
    public TextMeshProUGUI contadorPartiturasGUI;
    public Animator puertasJefes;

    // Start is called before the first frame update
    void Start()
    {
        numeroPartituras = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        contadorPartiturasGUI.text = (numeroPartituras).ToString();

        if (numeroPartituras == 6){
            puertasJefes.SetBool("estanDesbloqueadas", true);
        }        
    }
}
