using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivation : MonoBehaviour {
    Animator animator;
    public static bool doorOpen;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorOpen = true;
            Doors("Open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (doorOpen)
            {
                 doorOpen = false;
                 Doors("Close");
           }
        }
    }

    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }
}
