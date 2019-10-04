using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gestorDialogo : MonoBehaviour
{

	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;

	public Animator animator;

	public Animator NpcAnim;

	private Queue<string> sentences;

	public GameObject jugador;

	


	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		
	}

	public void StartDialogue (dialogo dialogos)
	{
		
		jugador.GetComponent<controlPersonaje>().enabled = false;

		NpcAnim.SetBool("estaHablando", true);
		animator.SetBool("IsOpen", true);

		nameText.text = dialogos.name;

		sentences.Clear();

		foreach (string sentence in dialogos.sentences)
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

	void EndDialogue()
	{
		
		jugador.GetComponent<controlPersonaje>().enabled = true;
		animator.SetBool("IsOpen", false);
		NpcAnim.SetBool("estaHablando", false);
	}

}
