using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemaPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject HUD;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Pausa();
        }       
    }

    public void Pausa()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        menuPausa.SetActive(true);
        HUD.SetActive(false);
        Time.timeScale = 0;
    } 

    public void Reanudar()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        menuPausa.SetActive(false);
        HUD.SetActive(true);
        Time.timeScale = 1;
    }             


}
