using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {

	public static int logCounter = 0;
	bool collided = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}


	void OnCollisionEnter(Collision info){

		if (info.gameObject.name == "Ball" && collided) {

			//count logs 
			GameMaster.logCounter += 1;
		
			Debug.Log("ball collided");
		
			//since we already counted this log set the if statement to false to user doesnt get mulitple
			//counts for one log
			collided= false;

			
		}
}
}