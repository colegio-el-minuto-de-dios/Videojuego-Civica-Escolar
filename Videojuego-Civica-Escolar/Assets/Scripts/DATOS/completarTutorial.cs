using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completarTutorial : MonoBehaviour
{
    public Transform jugador;
    public GameObject medalla;
    public Transform centro;    
    public GameObject camara;
    public GameObject HUD;
    //public progressIndicator sum;   
    public static bool cinematicaIslaPrincipal = false;
    public bool cargarIslaPrincipal = false;
    public float timmer;



    // Update is called once per frame
    void Update()
    {
        if(cargarIslaPrincipal == true){
            timmer += Time.deltaTime;
            if((timmer > 0.5f) && (timmer < 0.6f)){
                jugador.GetComponent<controlPersonaje>().enabled=false;
            }
           
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            HUD.SetActive(false);
            //sum.Tutorial();            
            //jugador.position = centro.position;
            //jugador.rotation = centro.rotation;            
            //camara.SetActive(true);
            //cinematicaIslaPrincipal = true;
            cargarIslaPrincipal = true;
            LoadYourAsyncScene();
            //subir medalla
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Isla principal");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
