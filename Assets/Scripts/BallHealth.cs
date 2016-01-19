using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;
	private bool isRestarting = false;
	public AudioClip GameOverSound;


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
		AudioSource audio = GetComponent<AudioSource> ();
		//yield return new WaitForSeconds (audio.clip.length);
		audio.Play ();

		transform.position = CheckPoint.reachedPoint;
	

}




	

}