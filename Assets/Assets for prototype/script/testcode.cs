using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//new code for jump
[RequireComponent(typeof(Rigidbody))]
//end new code

public class testcode : MonoBehaviour {
	public Transform bulletSpawn;
	public GameObject bulletPrefab;
	// Use this for initialization
	//void Start () {
		
	//}

	//new code for jump
	public Vector3 jump;
	public float jumpForce = 2.0f;
	public bool isGrounded;
	public static int bulletNumber = 8;
	Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody>();
		jump = new Vector3(0.0f, 5.0f, 0.0f); //3.0 means how high it will jump.
	}
	void OnCollisionStay()
	{
		isGrounded = true;
	}



	//end new code for jump



	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.F)) {  // pressfkey to fire
			if (bulletNumber > 0) {
				Fire ();
				bulletNumber = bulletNumber - 1;
			}
		}

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 10.0f;
		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);


		//new code for jump
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {

			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
		//end ew code for jump


	}

	void Fire(){
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

		Destroy (bullet, 2.0f);
	}

}
