using UnityEngine;
using System.Collections;


/* when level reloads in editor the lighting darkens dramatically, this supposedly doesn't show up in builds but to prevent it
 * in the editor follow this:
 * To fix it in the Editor, go to Window -> Lighting -> Lightmap Tab -> Disable Continuous Baking -> Press Build to bake the lighting once manually.

Note that if you add more lights or make some changes, you have to bake the lightmap again. */

public class LightupBall : MonoBehaviour {
	int height = 2;
	int distance = -5;
    public Transform target2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//find the object ball
		//GameObject ball = GameObject.Find ("Ball");
		//set position of camera to follow the ball
		transform.position = target2.position + (new Vector3 (0, height, distance));
		transform.LookAt (target2);
	
	}
}
