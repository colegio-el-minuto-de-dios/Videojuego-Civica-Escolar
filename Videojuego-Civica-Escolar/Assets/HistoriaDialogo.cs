using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HistoriaDialogo : MonoBehaviour
{

	public TextMeshProUGUI dialogueText;

    public Animator animador;
	
	private Queue<string> sentences;
	
	public float timmer;

	public string finHistoria;

	public GameObject panelImagenes;

	public Sprite[] ilustracionesHistoria;

	public static int imagenActual = 1;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		finHistoria = "No";
		timmer = 0;
	}

	public void StartDialogue (Dialogo dialogue)
	{	
		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{

		
		if (sentences.Count == 0)
		{
            animador.SetBool("iniciarTutorial",true);
              
			finHistoria = "Si";
			StartCoroutine(LoadScene());
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void Update(){
		if (finHistoria == "Si"){
			timmer += Time.deltaTime;		
			
		}
	}

	

	IEnumerator LoadScene(){
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Tutorial");
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        
        
        while (!asyncOperation.isDone){
            if ((asyncOperation.progress >= 0.9f) && (timmer > 8f))
            {
                asyncOperation.allowSceneActivation = true;   
            }

            yield return null;
        }
    }

	public void CambiarIlustración()
    {
 
        if (imagenActual == 1){
			panelImagenes.GetComponent<Image> ().sprite = ilustracionesHistoria [imagenActual];
            imagenActual++;
		} 
		else if (imagenActual == 2) {
            panelImagenes.GetComponent<Image> ().sprite = ilustracionesHistoria [imagenActual];
            imagenActual++;
        }
		else if (imagenActual == 3) {
            panelImagenes.GetComponent<Image> ().sprite = ilustracionesHistoria [imagenActual];
            imagenActual++;
        }
		else if (imagenActual == 4) {
            panelImagenes.GetComponent<Image> ().sprite = ilustracionesHistoria [imagenActual];
            imagenActual++;
        }
		else if (imagenActual == 5) {
            panelImagenes.GetComponent<Image> ().sprite = ilustracionesHistoria [imagenActual];
            
        }
 
        }

}
    

