using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavWander : MonoBehaviour
{
    Animator animator;
    public float wanderRadius;
    public float wanderTimer;
    public Transform player;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    public static int detected;





    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        detected = 0;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 15 && angle < 180)
        {

            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.3f);


            animator.SetBool("Idle", true);
            animator.SetBool("Walking", false);

            detected = 1;
        }
        else
        {

            detected = 0;
        }


        if (detected == 0)
        {

            animator.SetBool("Walking", true);
            animator.SetBool("Idle", false);

            timer += Time.deltaTime;

            if (timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }


        }


    }



    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}