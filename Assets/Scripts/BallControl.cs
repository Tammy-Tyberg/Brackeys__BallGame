using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	
	public int rotationSpeed = 100;
	public Rigidbody rb, rb1;
	public int jumpHeight = 8;
	private bool isFalling = false;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called Bonce per frame
	void Update () {
		
		//handle ball rotation 
		//respond to  A and D keys to rotate
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		
		//want to rotate rigid body using vector3.back since that'ts axis we r working with
		//multiply based on rotation speed and based on deltaTime so not on frame rate
		rb.AddRelativeTorque (Vector3.back * rotation);



		//if user presses space for jump
		if (Input.GetKeyDown (KeyCode.Space)  && !isFalling) {


			//set velocity in y axis to go up to 8 in y axis
			Vector3 v = rb.velocity;
			v.y = jumpHeight;
			rb.velocity = v;



		}

		//not touching an object so in air
		isFalling = true;

	}

	//called once per frame for object
	void OnCollisionStay(Collision collisionInfo){

		isFalling = false;
	}
}
