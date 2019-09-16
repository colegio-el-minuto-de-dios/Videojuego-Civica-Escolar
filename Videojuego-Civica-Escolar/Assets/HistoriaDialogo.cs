using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HistoriaDialogo : MonoBehaviour
{

	public TextMeshProUGUI dialogueText;

    public Animator animador;
	
	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		
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
            SceneManager.LoadScene("Tutorial", LoadSceneMode.Additive);            			
			EndDialogue();
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

	void EndDialogue()
	{
		
		
		
	}

}
    

