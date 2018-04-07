using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {

    public GameObject fishPrefab;
    public static int tankSize=15;

    // Create 10 fishes and make them in array
    static int numFish=30;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos;


	// Use this for initialization
	void Start () {
        //tankSize = 5;
        //set the initial goalPos to the fish manager's position (not sure if this how it works)
        goalPos = this.transform.position + Vector3.zero;

        for (int i=0; i < numFish; i++)
        {
            //Create 10 fishes; this assumer the center is at (0,0,0) and a larger tank (this one is > 10,10,10) 
            Vector3 pos = this.transform.position +  new Vector3(Random.Range(-tankSize, tankSize), Random.Range(-tankSize+13, tankSize-13), Random.Range(-tankSize, tankSize));

            allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);

        }


	}
	
	// Update is called once per frame
	void Update () {
        if (Random.Range(0, 10000) < 50)
        {
            goalPos = this.transform.position + new Vector3(Random.Range(-tankSize, tankSize), Random.Range(-tankSize+13, tankSize-13), Random.Range(-tankSize, tankSize));
        }



	}
}
