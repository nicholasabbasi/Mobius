using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotBomb : MonoBehaviour {

    public GameObject textPrefab;
    public Transform textSpwLoc;

   


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "Collectable bomb")
                    {
                        Blocker.hasBomb = true;

                        Instantiate(textPrefab, textSpwLoc.position, textSpwLoc.rotation);
                        
                        DestroyObject(this.gameObject);

                    }

                   
                }

            }


        }



    }
}
