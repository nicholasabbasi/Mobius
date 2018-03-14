using UnityEngine;

public class TriggerDestroy : MonoBehaviour {
    private void OnTriggerEnter(Collider collision) {
        if (collision.CompareTag("Player")) {
            TextHandler.INSTANCE.LeaveChat();
        }
    }
}