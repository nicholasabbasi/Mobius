/**
 * Author: Sander Homan
 * Copyright 2012
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BezierController : MonoBehaviour
{
    public BezierPath path = null;
    public float speed = 1;
    public bool byDist = false;

    public static int StartMove;

    private float t = 0;

    void Start()
    {
        StartMove = 0;

    }

    void Update()
    {
        if (StartMove == 1)
        {

            t += speed * Time.deltaTime;
            if (!byDist)
                transform.position = path.GetPositionByT(t);
            else
                transform.position = path.GetPositionByDistance(t);

        }
    }
}

