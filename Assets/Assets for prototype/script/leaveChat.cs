using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveChat : MonoBehaviour {

    public void destroyNleave()
    {
        Destroy(SpawnText.textbox);
       // textbox2 = Instantiate(TextPrefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        Destroy(spawnOnClick.textbox2);

        PlayerMove.stopMove = 0;
        Pathfollower2.freeze = 0;


    }
}
