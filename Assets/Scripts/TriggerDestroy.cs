using UnityEngine;

public class TriggerDestroy : MonoBehaviour {
    void OnTriggerEnter(Collider collision) {
        if (collision.CompareTag("Player")) {
            Destroy(SpawnText.textbox);
        }
    }
}