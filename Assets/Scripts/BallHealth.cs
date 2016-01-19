using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;

    public GameMaster gameMaster;


	// Use this for initialization
	void Start () {
	
		gameMaster = new GameMaster ();
	}
	
	// Update is called once per frame
	void Update () {
	//script is sittion on ball so use transform to get ball pos
		if (transform.position.y <= maxFallDistance) { 

			if(GameMaster.isRestarting == false){


				gameMaster.restartLevel();

				GameMaster.isRestarting = false;

			}
		
		}

	}







	

}