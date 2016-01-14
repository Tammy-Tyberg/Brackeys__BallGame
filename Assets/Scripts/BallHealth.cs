using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;
	private bool isRestarting = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//script is sittion on ball so use transform to get ball pos
		if (transform.position.y <= maxFallDistance) {

			if(isRestarting == false){

				restartLevel();
			}
		
		}

	}


	void restartLevel(){

		isRestarting = true;
		transform.position = CheckPoint.reachedPoint;
}

}