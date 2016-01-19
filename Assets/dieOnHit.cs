using UnityEngine;
using System.Collections;

public class dieOnHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	//unity will call when enter trigger
	void OnTriggerEnter(){

		Enemy enemy = transform.parent.GetComponentInParent<Enemy>();
		enemy.die ();

	}
}
