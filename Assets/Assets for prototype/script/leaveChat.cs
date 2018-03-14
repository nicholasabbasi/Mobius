using UnityEngine;

public class leaveChat : MonoBehaviour {
    public void destroyNleave() {
        Destroy(SpawnText.textbox);
        Destroy(spawnOnClick.textbox2);
    }
}