using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public static Vector3 reachedPoint;

	void OnTriggerEnter(Collider col){

		if (col.tag == "Player") {


			//if (transform.position.x > reachedPoint.x) {

				Debug.Log("passed checkpoint");
				reachedPoint = col.transform.position;

		


		}

	}



}
