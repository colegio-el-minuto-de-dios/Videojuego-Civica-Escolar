using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPdialogoRey : MonoBehaviour
{
    public GameObject contenedorBtn;    
    public GameObject btnDespedida;
    public GameObject interfazNPC;
    public GameObject camaraNPC;
    public GameObject selectorIslas;
    public GameObject HUD;


    public void BotonRechazar(){
        contenedorBtn.SetActive(false);
        btnDespedida.SetActive(true);   
    }

    public void BotonMapas(){
        HUD.SetActive(false);
        contenedorBtn.SetActive(false);
        interfazNPC.SetActive(false);
        camaraNPC.SetActive(false);
        selectorIslas.SetActive(true);

    }

    public void BotonDespedida(){
        contenedorBtn.SetActive(true);
        btnDespedida.SetActive(false);
        HUD.SetActive(true);
    }

    public void BotonReturn(){
        
        camaraNPC.SetActive(true);
        interfazNPC.SetActive(true);
        selectorIslas.SetActive(false);   
        btnDespedida.SetActive(true);     
        
    }

}
