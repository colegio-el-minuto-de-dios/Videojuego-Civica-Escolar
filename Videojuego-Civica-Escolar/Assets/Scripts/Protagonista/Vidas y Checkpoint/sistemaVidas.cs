using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemaVidas : MonoBehaviour
{

    public GameObject corazon1, corazon2, corazon3, corazon4, corazon5;
    public GameObject gameOverScreen;
    public static int salud;
    // Start is called before the first frame update
    void Start()
    {
        salud = 4;
        corazon1.gameObject.SetActive(true);
        corazon2.gameObject.SetActive(true);
        corazon3.gameObject.SetActive(true);
        corazon4.gameObject.SetActive(true);
        gameOverScreen.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (salud > 5){
            salud = 5;
        }
        if (salud < 0){
            salud = 0;
        }

        switch (salud){
            case 5:
            corazon1.gameObject.SetActive(true);
            corazon2.gameObject.SetActive(true);
            corazon3.gameObject.SetActive(true);
            corazon4.gameObject.SetActive(true);
            corazon5.gameObject.SetActive(true);
            break;
            case 4:
            corazon1.gameObject.SetActive(true);
            corazon2.gameObject.SetActive(true);
            corazon3.gameObject.SetActive(true);
            corazon4.gameObject.SetActive(true);
            corazon5.gameObject.SetActive(false);
            break;  
            case 3:
            corazon1.gameObject.SetActive(true);
            corazon2.gameObject.SetActive(true);
            corazon3.gameObject.SetActive(true);
            corazon4.gameObject.SetActive(false);
            corazon5.gameObject.SetActive(false);
            break;  
            case 2:
            corazon1.gameObject.SetActive(true);
            corazon2.gameObject.SetActive(true);
            corazon3.gameObject.SetActive(false);
            corazon4.gameObject.SetActive(false);
            corazon5.gameObject.SetActive(false);
            break;  
            case 1:
            corazon1.gameObject.SetActive(true);
            corazon2.gameObject.SetActive(false);
            corazon3.gameObject.SetActive(false);
            corazon4.gameObject.SetActive(false);
            corazon5.gameObject.SetActive(false);
            corazon5.gameObject.SetActive(false);
            break;  
            case 0:
            corazon1.gameObject.SetActive(false);
            corazon2.gameObject.SetActive(false);
            corazon3.gameObject.SetActive(false);
            corazon4.gameObject.SetActive(false);
            corazon5.gameObject.SetActive(false);
            gameOverScreen.gameObject.SetActive(true);
            break;  

        }
        
        
    }
}
