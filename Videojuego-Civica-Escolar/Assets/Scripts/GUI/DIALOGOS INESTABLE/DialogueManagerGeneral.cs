using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManagerGeneral : MonoBehaviour
{

	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;

	public Animator animator;

	public Animator NpcAnim;

	private Queue<string> sentences;

	public GameObject jugador;
	public GameObject camaraJugador;
	
 


	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		
	}

	public void StartDialogue (Dialogue dialogue)
	{
		camaraJugador.GetComponent<CameraFollow>().enabled = false;
		jugador.GetComponent<controlPersonaje>().enabled = false;

		NpcAnim.SetBool("estaHablando", true);
		animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

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

	public void EndDialogue()
	{
		camaraJugador.GetComponent<CameraFollow>().enabled = true;
		jugador.GetComponent<controlPersonaje>().enabled = true;
		print("dude ya esta");
		animator.SetBool("IsOpen", false);
		NpcAnim.SetBool("estaHablando", false);
		
	}

    

}
