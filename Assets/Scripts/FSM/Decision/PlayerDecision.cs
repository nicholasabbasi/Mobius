using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/Decisions/PlayerRadius")]
public class PlayerDecision : Decision {
    public int Radius = 10;
    
    public override bool Decide(StateController controller) {
        var hits = Physics.OverlapSphere(controller.transform.position, Radius);

        return hits.Any(hit => hit.CompareTag("Player"));
    }
}
