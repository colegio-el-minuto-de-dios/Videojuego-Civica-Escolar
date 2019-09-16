using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlHistoria : MonoBehaviour
{
    public Animator menus;
    // Start is called before the first frame update
    public void IniciarHistoria(){
        menus.SetBool("iniciarHistoria", true);
    }
}
