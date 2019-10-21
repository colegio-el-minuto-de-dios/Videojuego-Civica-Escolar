using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iniciarIsla : MonoBehaviour
{
    public float tiempoEspera;
    public bool estaPresionado;
    public static string prepararEscena;
    public Animator fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        tiempoEspera = 0f;
    }

    public void cargarIsla(){
        estaPresionado = true;
        fadeOut.SetBool("fadeOut",true); 
        StartCoroutine(LoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        if(estaPresionado == true){
            tiempoEspera += Time.deltaTime;            
        }
                        
    }


     IEnumerator LoadScene(){
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Pantalla de carga");
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        
        
        while (!asyncOperation.isDone){
            if ((asyncOperation.progress >= 0.9f) && (tiempoEspera > 2f))
            {
                asyncOperation.allowSceneActivation = true;   
            }

            yield return null;
        }
    }
}
