using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createobj : MonoBehaviour {
    public Transform Spawnpoint;
    public GameObject Prefab;

	void OnTriggerEnter () {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);

	}
	
	
}
