using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorIslas : MonoBehaviour
{
    public GameObject dialogos;
    public Animator fondoSolido;
    public GameObject habilitarPanel;
    public GameObject camaraJugador;
    public GameObject camaraPanel;
    public void MostrarMapa(){
        
        dialogos.SetActive(false);
        fondoSolido.SetBool("abierto", true);
        camaraJugador.SetActive(false);
        camaraPanel.SetActive(true);
        habilitarPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void CerrarMapa(){
        dialogos.SetActive(true);
        fondoSolido.SetBool("abierto", false);
        camaraJugador.SetActive(true);
        camaraPanel.SetActive(false);
        habilitarPanel.SetActive(true);
        FindObjectOfType<DialogueManagerGeneral>().DisplayNextSentence();
    }
}
