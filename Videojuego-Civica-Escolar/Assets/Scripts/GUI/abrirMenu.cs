using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirMenu : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("abrir");
                animator.SetBool("abrir", !isOpen);
            } 
        }
    }
}