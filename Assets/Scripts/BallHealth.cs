using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//script is sittion on ball so use transform to get ball pos
		if (transform.position.y <= maxFallDistance) {

			//normally let ball jump back to checkpoint but only have one level now
			//so just reload the level
			Application.LoadLevel("Level1");
			//Debug.Log ("Testing ball falling script");
		}

	}
}
