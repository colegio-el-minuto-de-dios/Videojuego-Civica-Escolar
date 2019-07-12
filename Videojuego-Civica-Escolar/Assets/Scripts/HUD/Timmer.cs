using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timmer : MonoBehaviour
{
    public  TextMeshProUGUI tiempoText;
    public float tiempo;
    public string nombreEscena;
    // Start is called before the first frame update

    void Start()
    {
        tiempoText = gameObject.GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>();
        tiempoText.color = Color.white;
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 20){
            tiempoText.color = Color.red;
        }
        if (tiempo <= 0){
            tiempo = 0;  
            Application.LoadLevel(nombreEscena);

        }

        tiempoText.text = "" + tiempo.ToString("f0");  


    }
}
