using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseActivateCart : MonoBehaviour
{


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            print("Found Hit!");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    print(hit.transform.parent.gameObject.name);
                    if (hit.transform.parent.gameObject.name == "VRLever")
                    {

                        BezierController.StartMove = 1;
                        // DoorActivation.doorOpen = true;
                       // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }

                   // PrintName(hit.transform.gameObject);
                }

            }


        }
    }
    
}
