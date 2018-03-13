using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberCatch : MonoBehaviour {
    //public GameObject robber;




   // public scoreboard scoreManager;
    //public int i=0;
    private void OnCollisionEnter(Collision collision)
    {

       // scoreManager.AddPoint();
        //testcode.bulletNumber = 8;
        Debug.Log("Collision detected");
        Destroy(gameObject);
        SpawnText.afterEvent = 1;


    }
}
