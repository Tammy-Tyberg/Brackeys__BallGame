using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(string level){
		Application.LoadLevel (level);
	}



	public void quitGame(){
	
		Debug.Log ("Game is exiting...");
		Application.Quit ();

	}
}
