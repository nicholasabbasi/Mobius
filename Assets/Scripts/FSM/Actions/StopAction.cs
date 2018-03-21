using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Stop")]
public class StopAction : Action {
	public override void Act(StateController controller) {
		var nav = controller.NavMeshAgent;
		nav.isStopped = true;
	}
}