using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPausa : MonoBehaviour
{
    public string nombreEscena;
    void Awake() {
        Time.timeScale = 1;
    }
    public void ReiniciarMision()
    {
        // Load the level named "HighScore".
        Application.LoadLevel(nombreEscena);
    }
}
