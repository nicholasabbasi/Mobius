using System.Collections;
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

	private FirstPersonController _controller;
	
	public void Interact(MouseInteract other) {
		if (!other.CompareTag("Player")) return;
		_controller = other.GetComponent<FirstPersonController>();
		
		_controller.enabled = false;
		
		OnText(0);
	}

	public void OnText(int index) {
		_tree.ChooseOption(index);
		
		var answers = _tree.Current.options.Select(it => it.text).ToArray();
		
		TextHandler.INSTANCE.SpawnText(_tree.Current.text, answers, OnText);

		if (_tree.IsFinished) {
			_controller.enabled = true;
			TextHandler.INSTANCE.LeaveChat();
		}
	}
}
