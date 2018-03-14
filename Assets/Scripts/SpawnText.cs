using UnityEngine;

public class SpawnText : MonoBehaviour {
    public GameObject TextPrefab;
    public GameObject TextPrefab2;
    public static GameObject textbox;
    public static bool afterEvent = false;


    void OnTriggerEnter(Collider collision) {
        if (!collision.CompareTag("Player")) {
            return;
        }

        textbox = Instantiate(afterEvent ? TextPrefab2 : TextPrefab);
    }
}