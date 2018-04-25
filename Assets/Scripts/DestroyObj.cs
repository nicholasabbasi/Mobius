using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

    public float timeDelay = 3f;
    public static int countDown;
	// Use this for initialization
	void Start () {
        countDown = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //if (countDown == 1)
       // {
            timeDelay -= Time.deltaTime;
            if (timeDelay <= 0)
            {
            Destroy(gameObject);
        }
       // }
	}
}
