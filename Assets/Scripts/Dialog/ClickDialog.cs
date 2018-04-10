﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ClickDialog : MonoBehaviour, IInteractable {
	
	public string CharacterName;

	private DialogTree _tree;

	// Use this for initialization
	private void Start () {
		_tree = new DialogTree(CharacterName);
	}
	
	public void Interact(MouseInteract other) {
		if (!other.CompareTag("Player")) return;
		var controller = other.GetComponent<FirstPersonController>();
		
		controller.enabled = false;

		var answers = _tree.Current.options.Select(it => it.text).ToArray();
			
		TextHandler.INSTANCE.SpawnText(_tree.Current.text, answers, delegate(int index) {
			_tree.ChooseOption(index);

			if (_tree.IsFinished) {
				controller.enabled = true;
				TextHandler.INSTANCE.LeaveChat();
			}
		});
	}
}
