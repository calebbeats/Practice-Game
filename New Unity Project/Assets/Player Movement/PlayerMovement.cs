using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetButton deals with the input manager. We should use this/

		if (Input.GetButton ("fire1")) {
			Debug.Log ("Pressed Fire1 key");
		}
		if (Input.GetKeyDown ("s")) {
			Debug.Log ("Pressed S key");
		}
		if (Input.GetKeyUp ("a")) {
			Debug.Log ("Pressed A key");
		}
		if (Input.GetKey ("d")) {
			Debug.Log ("Pressed D key");
		}
		// Left mouse is 0, Right mouse is 1.
		if (Input.GetMouseButton (0)) {
			Debug.Log ("Left Mouse");
		}
	}
}
