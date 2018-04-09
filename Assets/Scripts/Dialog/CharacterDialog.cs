using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialog: MonoBehaviour {

	public string CharacterName;

	// private DialogTree _tree;

	// Use this for initialization
	private void Start () {
		// _tree = new DialogTree(CharacterName);
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			print("Collided. Spawning Text.");
			TextHandler.INSTANCE.SpawnText("Hi!");
		}
	}
}
