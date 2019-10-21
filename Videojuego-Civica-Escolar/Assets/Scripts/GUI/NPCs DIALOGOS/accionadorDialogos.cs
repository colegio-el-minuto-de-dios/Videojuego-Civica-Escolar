using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accionadorDialogos : MonoBehaviour
{

	public dialogo dialogos;

	public void TriggerDialogue ()
	{
		FindObjectOfType<gestorDialogo>().StartDialogue(dialogos);
	}

}
