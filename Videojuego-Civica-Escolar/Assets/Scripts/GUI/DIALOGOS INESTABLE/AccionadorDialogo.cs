using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionadorDialogo : MonoBehaviour{

	public Dialogo dialogue;

	void TriggerDialogue ()
	{
		FindObjectOfType<HistoriaDialogo>().StartDialogue(dialogue);
	}

}