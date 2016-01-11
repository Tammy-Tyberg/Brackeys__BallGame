using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	
	public int rotationSpeed = 100;
	public Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called Bonce per frame
	void Update () {
		
		
		//respond to  A and D keys to rotate
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		
		//want to rotate rigid body using vector3.back since that'ts axis we r working with
		//multiply based on rotation speed and based on deltaTime so not on frame rate
		rb.AddRelativeTorque (Vector3.back * rotation);
		
	}
}
