using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcDialogo : MonoBehaviour
{
   [SerializeField] GameObject cuadroDialogo;
   [SerializeField] private Animator Animador;

   void OnTriggerEnter(Collider other) {
       if (other.CompareTag("Player"))
       {
           cuadroDialogo.SetActive(true);
           Animador.SetBool("enCercania", true);
           Cursor.lockState = CursorLockMode.None;

       }
   }

   void OnTriggerExit(Collider other) {
       if (other.CompareTag("Player"))
       {
           cuadroDialogo.SetActive(false);
           Animador.SetBool("enCercania", false);
           Cursor.lockState = CursorLockMode.Locked;
       }       
   }
}
