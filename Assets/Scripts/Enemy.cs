using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Rigidbody player;
	public int bounceAmount = 10;
	public Transform deathParticles;

	// Use this for initialization
	void Start () {

		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//destroy the game object this is assigned to enemy so that's the gameObject
public 	void die(){

		//this is not working the ball is not jumping up after hitting/ so no bounce effect
		Vector3 v = player.velocity;
		v.y =  v.y * bounceAmount;
		player.velocity = v;

		Instantiate (deathParticles, transform.position, transform.rotation);
		Destroy (gameObject);
	
	}
}
