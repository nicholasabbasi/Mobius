using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnobj : MonoBehaviour {
	public Transform Spawnpoint;
	public GameObject Prefab;
	public int i=0;
	public static int Destroyed = 0;
	void Update()
	{

		if (Destroyed == 1) {
			i++;

			if (i > 200) {
				Instantiate (Prefab, Spawnpoint.position, Spawnpoint.rotation);
				i = 0;
				Destroyed = 0;
			}
		}
	}

}