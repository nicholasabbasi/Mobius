using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseClickActivation : MonoBehaviour
{
    Animator animator;
    public static bool doorOpen;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }



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
                    if (hit.transform.gameObject.name == "Xdoor")
                    {
                        if (doorOpen)
                        {
                            doorOpen = false;
                            Doors("Close");
                        }
                        else
                        {
                            doorOpen = true;
                            Doors("Open");
                        }
                    


                        // DoorActivation.doorOpen = true;
                        // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }
                    
                    //PrintName(hit.transform.gameObject);
                }

            }


        }
    }


    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }


    /*
    private void PrintName(GameObject go)
    {
        if (go.name == "Cube")
        {
            print(go.name);
            Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

        }
    }

    */
}
