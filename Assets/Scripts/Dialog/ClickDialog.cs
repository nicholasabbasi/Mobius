using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ClickDialog : CHDialog, IInteractable {

	public void Interact(MouseInteract other) {
		if (!other.CompareTag("Player")) return;
		var controller = other.GetComponent<FirstPersonController>();

		StartDialog(controller);
	}
}
