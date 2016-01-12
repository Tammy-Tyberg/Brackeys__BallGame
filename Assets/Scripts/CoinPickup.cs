using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int coinCounter = 0;
	public Transform coinEffectParticles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider info){

		if (info.name == "Ball") {
			Transform effect = Instantiate(coinEffectParticles, transform.position, transform.rotation)as Transform;
			Destroy(effect.gameObject, 3);
			//Debug.Log("ball collided");
			Destroy(gameObject);
			coinCounter++;

		}



	}
}
