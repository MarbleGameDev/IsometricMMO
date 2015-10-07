using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	WindowManager window;
	// Use this for initialization
	void Start () {
		window = GameObject.Find ("Window").GetComponent<WindowManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (window.windowOpen == false) {
			float horizontalMovement = Input.GetAxis ("Horizontal");
			float verticalMovement = Input.GetAxis ("Vertical");
			if (horizontalMovement != 0) {
				transform.Translate (horizontalMovement, 0, 0);
			}
			if (verticalMovement != 0) {
				transform.Translate (0, 0, verticalMovement);
			}
		}
	}
}
