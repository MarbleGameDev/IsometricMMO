using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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
