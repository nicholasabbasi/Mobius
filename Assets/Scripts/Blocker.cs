using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour {

    public static bool Bombed;
    public Transform Spawnpoint;
    public GameObject Prefab;
    // Use this for initialization
    void Start () {
        Bombed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Bombed == true)
        {
            Destroy(gameObject);
        }



        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "Blocker")
                    {
                        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);

                       // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }


                }

            }


        }






    }
}
