using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
 using UnityEngine.UI;

public class contadorReciclaje : MonoBehaviour
{
    public static float reciclajeCorrecto;
    public TextMeshProUGUI contadorGUI;
    public static float itemsMisil = 0;
    public Button botonLanzarMisil;
    // Start is called before the first frame update
    void Start()
    {
        itemsMisil = 0;     
        botonLanzarMisil.interactable = false;    
    }

    void Update(){
        contadorGUI.text = itemsMisil.ToString();
        if (itemsMisil > 3){
            itemsMisil = 3;
        } 

        if (((itemsMisil <= 3) && (itemsMisil > 0)) &&  arosReciclaje.aroSeleccionado != ""){
            botonLanzarMisil.interactable = true;    
        }
        else{
            botonLanzarMisil.interactable = false;    
        }
    }

    public void DeshabilitarBoton(){
        botonLanzarMisil.interactable = false;
    }

    
}
