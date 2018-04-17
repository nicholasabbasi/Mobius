using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RadiusDialog: CHDialog {
	public void OnTriggerEnter(Collider other) {
		if (!other.CompareTag("Player")) return;
		var controller = other.GetComponent<FirstPersonController>();
		
		StartDialog(controller);
	}
}
