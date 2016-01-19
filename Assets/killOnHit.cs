using UnityEngine;
using System.Collections;

public class killOnHit : MonoBehaviour {


	GameMaster gameMaster;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){

		gameMaster.restartLevel ();



	}
}
