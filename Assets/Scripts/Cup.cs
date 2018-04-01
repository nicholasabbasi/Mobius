using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour {



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "Chalice")
                    {
                      
                         Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }

                   
                }

            }


        }
    }


}
