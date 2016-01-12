using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public static int currentScore = 0;
	public int scoreInspector = currentScore;
	public int scoreY = Screen.height - (Screen.height - 30);
	public int scoreSizeX = 200;
	public int scoreSizeY = 50;
	// Use this for initialization
	void Start () {
	
	}

	void Update(){

		scoreInspector = currentScore;

	}
	
	// Update is called once per frame
	void OnGUI () {
	
		GUI.Box (new Rect (Screen.width/3, scoreY, scoreSizeX, scoreSizeY ), "Score: " + currentScore);



	}
}
