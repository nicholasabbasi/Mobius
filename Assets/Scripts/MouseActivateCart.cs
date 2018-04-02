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

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "VRLever")
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

    /*
    private void PrintName(GameObject go)
    {
        if (go.name == "Cube")
        {
            print(go.name);
            //Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

        }
    }
    */
    
}
