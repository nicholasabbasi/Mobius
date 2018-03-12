using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollower2 : MonoBehaviour {

    public Transform[] path;
    public float speed = 5.0f;
    public float reachDist = 1.0f;
    public int currentPoint = 0;

    public static int freeze;

	// Use this for initialization
	void Start () {
        freeze = 0;

    }
	
	// Update is called once per frame
	void Update () {

      //  Debug.Log("xxxx"+freeze);
       
        
        // Vector3 dir =  path[currentPoint].position - transform.position ;
        
        if (freeze == 0)
        {

            float dist = Vector3.Distance(path[currentPoint].position, transform.position);

            transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, Time.deltaTime * speed);

            //transform.position += dir * Time.deltaTime * speed;
            if (dist <= reachDist)
            {
                currentPoint++;
            }

            if (currentPoint >= path.Length)
            {
                currentPoint = 0;
            }
        }
        

	}

    void OnDrawGizmos()
    {
        if(freeze == 0) { 
            
            if (path.Length > 0)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] != null)
                    {
                     Gizmos.DrawSphere(path[i].position, reachDist);
                    }


                 }
            }
            
        }

        
    }

}
