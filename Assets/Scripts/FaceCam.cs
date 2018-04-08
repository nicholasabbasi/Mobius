using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCam : MonoBehaviour {

    public Transform camTransform;
    Quaternion originalRotation;


	// Use this for initialization
	void Start () {
        originalRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = camTransform.rotation * originalRotation;
	}
}
