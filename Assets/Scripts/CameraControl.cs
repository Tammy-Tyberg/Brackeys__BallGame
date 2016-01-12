using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {


   public Transform target;
	public int distance = -10; //so camera baxked up ten units in set axis
	public float lift = 1.5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//position of this object which is the camera so I guess it's the object you're scripting on

		transform.position = target.position + (new Vector3 (0, lift, distance));//set positon based on vector, want to set to balls x
		//so stays zero, want equal to y plus 1.5 so put lift, and add distance to -10 this works since we set target
		//to the ball object in inspector so camera pos should be equal to ball distance plus modifications


		//when ball goes up want to camera to look at ball so say camera look at the target (which is the ball)
		transform.LookAt (target);

	
	}
}
