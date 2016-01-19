using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public static int currentScore = 0;
	public static int logCounter = 0;
	public int scoreInspector = currentScore;
	public int scoreY = Screen.height - (Screen.height - 30);
	public int scoreSizeX = 200;
	public int scoreSizeY = 50;
	public Transform Player;
	public AudioClip GameOverSound;
	public static bool isRestarting = false;
	// Use this for initialization
	void Start () {

		currentScore = 0;
	}

	void Update(){

		//scoreInspector = currentScore;

	}
	
	// Update is called once per frame
	void OnGUI () {
	
		GUI.Box (new Rect (Screen.width/3, scoreY, scoreSizeX, scoreSizeY ),
		         "Score: " + currentScore + "Logs:" + logCounter);


	}

	public void restartLevel(){
		
		isRestarting = true;
		Debug.Log ("entered restart level");
		//AudioSource audio = GetComponent<AudioSource> ();
		//yield return new WaitForSeconds (audio.clip.length);
		//audio.Play ();
		//Instantiate (Player, transform.position, transform.rotation);
		Player.position = CheckPoint.reachedPoint;
		
		isRestarting = false;
	}
}
