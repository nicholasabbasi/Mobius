using UnityEngine;


public class MouseInteract : MonoBehaviour {
    private void Update() {
        // Check for mouse.
        if (!Input.GetMouseButtonDown(0)) return;
        
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (!Physics.Raycast(ray, out hit, 100.0f)) return;
        if (!hit.transform) return;

        if (hit.transform.parent) {
            if (hit.transform.parent.gameObject.name == "VRLever") {
                BezierController.StartMove = 1;
            }
        }

        var interact = hit.transform.GetComponent<IInteractable>();

        if (interact != null) {
            interact.Interact(this);
        }
    }
}

public interface IInteractable {
    void Interact(MouseInteract interact);
}