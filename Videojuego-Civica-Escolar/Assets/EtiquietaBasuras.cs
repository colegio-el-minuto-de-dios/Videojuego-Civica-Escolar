using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtiquietaBasuras : MonoBehaviour
{
    public GameObject etiqueta;
    
    void Update()
    {
        Vector3 posicionEtiqueta= Camera.main.WorldToScreenPoint(this.transform.position);
        etiqueta.transform.position = posicionEtiqueta;        
    }
}
