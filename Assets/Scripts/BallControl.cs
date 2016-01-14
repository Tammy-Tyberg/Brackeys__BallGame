using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	
	public int rotationSpeed = 100;
	public Rigidbody rb, rb1;
	public int jumpHeight = 8;
	public int superJumpHeight = 12; //height of super jump
	private bool isFalling = false;
	public Transform SuperJumpParticles;
	static int superJumpWaitTime = 180; //wait 180 frames between super jumps
	 int framesSinceSuperJump = superJumpWaitTime; //counter since last jump starts with 180 
	float distanceToGround;

	// Use this for initialization
	void Start () {

		//getting distance from center to groun
		//distanceToGround = Collider.bounds.extents.y;
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called Bonce per frame
	void Update () {
		//Debug.Log ("super jump counter is " + framesSinceSuperJump);

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

		//added super jump user can use every 180 frames about 3 second 
		if(Input.GetKeyDown(KeyCode.S) && framesSinceSuperJump >= superJumpWaitTime ){
		
					Vector3 v = rb.velocity;
					v.y = superJumpHeight;
					Transform effect = Instantiate(SuperJumpParticles, transform.position, transform.rotation)as Transform;
					rb.velocity = v;
					framesSinceSuperJump = 0;
					Destroy(effect.gameObject, 6);
					
		}

		//not touching an object so in air
		isFalling = true;
		framesSinceSuperJump++;

	}

	//called once per frame for object
	void OnCollisionStay(Collision collisionInfo){

		isFalling = false;
	}

	//check if on ground return true if yes 
	/*bool isGrounded(){

		return Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);

	}*/
}
