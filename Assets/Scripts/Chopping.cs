using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopping : MonoBehaviour {
    private float chop_time;
   // Animator animator;

    // Use this for initialization
    void Start () {
        // animator = GetComponent<Animator>();
        chop_time = 2f;

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<AudioSource>().Play();
        chop_time -= Time.deltaTime;
        /*
        if (chop_time % 2 ==0)
        {
            animator.SetTrigger("Idle");
      
        }
        else
        {
            animator.SetTrigger("Swing");
        }
        */
        if (chop_time<=0)
        {
            Destroy(gameObject);

        }

	}
}
