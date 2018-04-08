using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseClickActivation : MonoBehaviour
{
    Animator animator;
    public static bool doorOpen;

  //  public Transform Spawnpoint;
  //  public GameObject Prefab;

    public static int PW_Entered;
    public static int Pad_spawned;


    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
        PW_Entered = 0;
        Pad_spawned = 0;
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
                            if (Pad_spawned == 0)
                            {
                           // Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
                            }
                        //need to sovle the PW puzzel before open door
                           // if (PW_Entered == 1)
                           // {
                                if (doorOpen)   //the door is openning
                                {
                                    doorOpen = false; 
                                    Doors("Close");
                                   
                                }
                                else          //the door is closing
                                {
                                    doorOpen = true;
                                    Doors("Open");
                                  

                                }

                           

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
