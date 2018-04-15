using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour {

    public static bool Bombed;
    public static bool hasBomb;
    float display_Time;
    bool textUp;
    GameObject hintText;

    public Transform Spawnpoint;
    public GameObject PrefabBomb;
    public GameObject PrefabText;


    // Use this for initialization
    void Start () {
        Bombed = false;
        hasBomb = false;
        display_Time = 0f;
        textUp = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Bombed == true)
        {
            Destroy(gameObject);

        }

        display_Time -= Time.deltaTime;

        if(textUp == true && display_Time <= 0)
        {
            Destroy(hintText);
            textUp = false;
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
                        if (hasBomb == true) // has a bomb on hand, spawn and bomb it
                        {
                            Instantiate(PrefabBomb, Spawnpoint.position, Spawnpoint.rotation);
                        }
                        else
                        {
                            display_Time = 2f;

                            hintText = Instantiate(PrefabText, Spawnpoint.position, Spawnpoint.rotation);

                            textUp = true;


                        }

                       // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }


                }

            }


        }






    }
}
