using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour
{
    public string escenaNivel;
    public float detenerTiempo;
    public bool reintentar = false;
    public float tiempoDesmontarEscena;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;   
        reintentar = false;     
    }

    // Update is called once per frame
    void Update()
    {
        detenerTiempo += Time.deltaTime;       
        if (detenerTiempo >= 1.5f){
            Time.timeScale = 0.001f;
        } 

        if(reintentar == true){
            Time.timeScale = 1f;
            tiempoDesmontarEscena += Time.deltaTime;
            if (tiempoDesmontarEscena >= 1){
                SceneManager.LoadScene(escenaNivel, LoadSceneMode.Additive);
                SceneManager.UnloadScene("Pantalla perdiste");
                Time.timeScale = 1f;
                reintentar = false;
            }

        }        
    }

    public void Reintentar(){        
        SceneManager.UnloadScene(escenaNivel);
        reintentar = true;
        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;   
    }

    public void Abandonar(){
        SceneManager.LoadScene("IslaPrincipal");
        Time.timeScale = 1f;
    }



}
