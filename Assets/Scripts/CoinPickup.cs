using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {
	public int coinCounter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider info){

		if (info.name == "Ball") {
			Debug.Log("ball collided");
			Destroy(gameObject);
			coinCounter++;

		}



	}
}
