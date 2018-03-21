using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Patrol")]
public class PatrolAction : Action {
    public override void Act(StateController controller) {
        var nav = controller.NavMeshAgent;

        var waypoints = OrderedWaypoint.Get(controller.WaypointType);

        var waypoint = waypoints[controller.NextWayPoint];
        RaycastHit hit;

        if (Physics.Raycast(waypoint.transform.position, Vector3.down, out hit)) {
            nav.destination = hit.point;
        }

        nav.isStopped = false;

        if (nav.remainingDistance <= nav.stoppingDistance && !nav.pathPending) {
            controller.NextWayPoint = (controller.NextWayPoint + 1) % waypoints.Count;
        }
    }
}