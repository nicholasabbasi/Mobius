using UnityEngine;

public class spawnOnClick : MonoBehaviour {
    public Transform Spawnpoint2;
    public GameObject TextPrefab2;
    public static GameObject textbox2;

    public void spawnText()
    {
        textbox2 = Instantiate(TextPrefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        Destroy(SpawnText.textbox);
    }
}
