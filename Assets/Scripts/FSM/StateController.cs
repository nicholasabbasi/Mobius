using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
    public class StateController : MonoBehaviour {
    public State CurrentState;
    public State RemainState;
    
    // For drawing the debugging.
    public Transform Eyes;
    public float Size = 1;
    
    public List<Transform> Waypoints;

    [HideInInspector] public NavMeshAgent NavMeshAgent;
    [HideInInspector] public int NextWayPoint;
    [HideInInspector] public Transform ChaseTarget;
    [HideInInspector] public float StateTimeElapsed;

    private bool _active;

    public bool Active {
        get { return _active; }
        set {
            NavMeshAgent.enabled = value;
            _active = value;
        }
    }

    private void Awake() {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        Active = true;
    }

    private void Update() {
        if (!Active)
            return;
        CurrentState.UpdateState(this);
    }

    private void OnDrawGizmos() {
        if (CurrentState != null && Eyes != null) {
            Gizmos.color = CurrentState.SceneGizmoColor;
            Gizmos.DrawWireSphere(Eyes.position, Size);
        }
    }

    public void TransitionToState(State nextState) {
        if (nextState != RemainState) {
            CurrentState = nextState;
            OnExitState();
        }
    }

    public bool HasTimeElapsed(float duration) {
        StateTimeElapsed += Time.deltaTime;
        return StateTimeElapsed >= duration;
    }

    private void OnExitState() {
        StateTimeElapsed = 0;
    }
}