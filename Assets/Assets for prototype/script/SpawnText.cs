using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnText : MonoBehaviour {

    public Transform Spawnpoint;
    public GameObject TextPrefab;
    public static GameObject textbox;


    
    public Renderer rend;
    /*
    void Start()
    {
        rend = GetComponent<Renderer>();
        //rend.enabled = true;
        rend.enabled = false;
    }
    */


    void OnTriggerEnter(Collider collision)
    {
         if (collision.CompareTag("player"))
         {
        textbox = Instantiate(TextPrefab, Spawnpoint.position, Spawnpoint.rotation);

        Pathfollower2.freeze = 1;
            PlayerMove.stopMove = 1;
        //Debug.Log("Yay spawn " + Pathfollower2.freeze);

         }
        //Destroy(textbox, 8.0f);  // yes, this will destroy the text in about 8 sec

    }

}
