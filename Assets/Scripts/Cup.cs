using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour {

    public GameObject player;

    public void OnCollisionEnter(Collision collision)
    {
        GameObject var = collision.gameObject;
        if(var == player)
        {
            Destroy(this.gameObject);
        }
    }
}
