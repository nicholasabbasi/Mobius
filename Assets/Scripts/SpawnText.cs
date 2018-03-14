using UnityEngine;

public class SpawnText : MonoBehaviour {
    public GameObject TextPrefab;


    void OnTriggerEnter(Collider collision) {
        if (!collision.CompareTag("Player")) {
            return;
        }

        TextHandler.INSTANCE.SpawnText(TextPrefab);
    }
}