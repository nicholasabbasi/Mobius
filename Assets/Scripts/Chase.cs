using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Chase : MonoBehaviour {

    public Transform player;
    public Animator anim;
    public static int detected;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        detected = 1;

	}
	
	// Update is called once per frame
	void Update () {

        if (detected == 1)
        {

            Vector3 direction = player.position - this.transform.position;
            float angle = Vector3.Angle(direction, this.transform.forward);
            if (Vector3.Distance(player.position, this.transform.position) < 15 && angle < 90)
            {

                direction.y = 0;

                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.3f);

                anim.SetBool("isIdle", false);
                if (direction.magnitude > 5)
                {
                    this.transform.Translate(0, 0, 0.05f);
                    anim.SetBool("isWalking", true);
                    anim.SetBool("isAttacking", false);
                }
                else
                {
                    anim.SetBool("isAttacking", true);
                    anim.SetBool("isWalking", false);
                }

            }
            else
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", false);
            }

        }
	}

}
