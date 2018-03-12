using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy : MonoBehaviour {
    // public object pc;
    //public object pc;
    //  public GameObject objToDestroy;

    // void OnTriggerEnter()
    // {
    //   Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    // }


    void OnTriggerEnter(Collider  collision )
    {
        if (collision.CompareTag("player"))
        {
        
            Destroy(SpawnText.textbox);
            Pathfollower2.freeze = 0;
            PlayerMove.stopMove = 0;
            Debug.Log("Yay "+ Pathfollower2.freeze);

        }
            

        //if (other.gameObject.tag == "Player")
         //   Destroy(SpawnText.textbox);

      //  Pathfollower2.freeze = 0;
      //  PlayerMove.stopMove = 0;
    }


}
