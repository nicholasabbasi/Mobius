using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reload : MonoBehaviour {
	public int i=0;
	public Transform Spawnpoint;
	public GameObject Prefab;


	void OnCollisionEnter(Collision collision){
		Debug.Log ("Collision detected");

		testcode.bulletNumber = 8;	
		respawnobj.Destroyed = 1;//Debug.Log (testcode.bulletNumber);
		Destroy (gameObject);


	}
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    
    void Update () {
		
		
	}
    
}
