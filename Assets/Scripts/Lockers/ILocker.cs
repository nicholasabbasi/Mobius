﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ILocker : MonoBehaviour {

    Animator animator;
    public static bool doorOpen;

    public static int PW_Entered;



    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
        PW_Entered = 0;               //need password to turn it 1

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
                    if (hit.transform.gameObject.name == "IDoor")   // for I locker only
                    {
                        if (PW_Entered == 1)
                        {

                            if (doorOpen)          //door is openning
                            {
                                GetComponent<AudioSource>().Play();
                                Doors("Close");
                                doorOpen = false;
                                // set next locker false
                                SLocker.PW_Entered = 0;
                            }
                            else                  //door is closing
                            {
                                GetComponent<AudioSource>().Play();
                                Doors("Open");
                                doorOpen = true;
                                //set next locker true
                                SLocker.PW_Entered = 1;

                            }
                        }

                        else
                        {
                            // should kill player when it try to open this door
                            Scenes.LoadMainScene();//(SceneManager.GetActiveScene ().name);

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
