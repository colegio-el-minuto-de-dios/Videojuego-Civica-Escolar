using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cargarIsla : MonoBehaviour
{
    public float tiempoEspera;
    public string islaCarga;
    // Start is called before the first frame update
    void Start(){
         

        switch (iniciarIsla.prepararEscena)
      {
          case "Uno":
              islaCarga = "Isla robot";
              break;
          case "Dos":
              islaCarga = "Isla biblioteca";
              break;
          case "Tres":
              islaCarga = "Isla musical";
              break;
          case "Cuatro":
              islaCarga = "Isla tienda";
              break;
          case "Crinco":
              islaCarga = "";
              break;
        
      }
        tiempoEspera = 0f;   
        StartCoroutine(LoadScene());
    }

    void Update(){
        tiempoEspera += Time.deltaTime;
    }

     IEnumerator LoadScene(){
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(islaCarga);
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        
        
        while (!asyncOperation.isDone){
            if ((asyncOperation.progress >= 0.9f) && (tiempoEspera > 8f))
            {
                asyncOperation.allowSceneActivation = true;   
            }

            yield return null;
        }
    }
}
