using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLocker : MonoBehaviour {
    Animator animator;
    public static bool doorOpen;

    public static int PW_Entered;
 


    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
        PW_Entered = 1;               //D locker doesn't need password
       
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
                    if (hit.transform.gameObject.name == "DDoor")   // for D locker only
                    {
                       
                       
                        if (doorOpen)          //door is openning
                        {
                            GetComponent<AudioSource>().Play();
                            Doors("Close");
                            doorOpen = false;
                            // set next locker false
                            ILocker.PW_Entered = 0;
                        }
                        else                  //door is closing
                        {
                            GetComponent<AudioSource>().Play();
                            Doors("Open");
                            doorOpen = true;
                            //set next locker true
                            ILocker.PW_Entered = 1;

                        }

                        

                    }

                   
                }

            }


        }

    }


    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }
}
