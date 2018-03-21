using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/State")]
public class State : ScriptableObject {
    public Action[] Actions;
    public Transition[] Transitions;
    public Color SceneGizmoColor = Color.grey;

    public void UpdateState(StateController controller) {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(StateController controller) {
        foreach (var t in Actions) {
            t.Act(controller);
        }
    }

    private void CheckTransitions(StateController controller) {
        foreach (var t in Transitions) {
            var decisionSucceeded = t.Decision.Decide(controller);

            controller.TransitionToState(decisionSucceeded ? t.TrueState : t.FalseState);
        }
    }
}