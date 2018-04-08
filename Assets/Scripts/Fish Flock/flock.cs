﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flock : MonoBehaviour {
    public float speed = 0.001f;
    float rotationSpeed = 4.0f;
    Vector3 averageHeading;
    Vector3 averagePostion;
    float neifhbourDistance = 3.0f;

    bool turning = false;


	// Use this for initialization
	void Start () {
        speed = Random.Range(0.5f, 1);        
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position, (Vector3.zero + globalFlock.goalPos)) >= globalFlock.tankSize)
        {
            turning = true;
        }
        else
        {
            turning = false;
        }

        if (turning)
        {
            Vector3 direction = globalFlock.goalPos - transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);

            speed = Random.Range(0.5f, 1);
        }
        else {
            if (Random.Range(0, 5) < 1)
            {
                ApplyRules();
            }
        }

       
        transform.Translate(0, 0, Time.deltaTime * speed);
	}

    void ApplyRules()
    {
        GameObject[] gos;
        gos = globalFlock.allFish;

        Vector3 vcentre = globalFlock.goalPos;            //Vector3.zero; replace thise (0,0,0) with the finish manager position
        Vector3 vavoid = globalFlock.goalPos;              //Vector3.zero;
        float gSpeed = 0.1f;

        Vector3 goalPos = globalFlock.goalPos;

        float dist;

        int groupSize = 0;
        foreach (GameObject go in gos)
        {
            if(go != this.gameObject)
            {
                dist = Vector3.Distance(go.transform.position, this.transform.position);
                if (dist <= neifhbourDistance) {
                    vcentre += go.transform.position;
                    groupSize++;

                    if (dist < 1.0f) {
                        vavoid = vavoid + (this.transform.position - go.transform.position);
                    }

                    flock anotherFlock = go.GetComponent<flock>();

                    gSpeed = gSpeed + anotherFlock.speed;


                }

            }

        }


        if(groupSize > 0)
        {
            vcentre = vcentre / groupSize + (goalPos - this.transform.position);
            speed = gSpeed / groupSize;

            Vector3 direction = (vcentre + vavoid) - transform.position;
            if (direction != this.transform.position) {

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            }

        }


    }



}
