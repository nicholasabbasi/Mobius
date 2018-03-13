using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnOnClick : MonoBehaviour {
    public Transform Spawnpoint2;
    public GameObject TextPrefab2;
    public static GameObject textbox2;

    public void spawnText()
    {
        textbox2 = Instantiate(TextPrefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        Destroy(SpawnText.textbox);
        GateOpen.close = 0;
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
