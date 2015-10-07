using UnityEngine;
using System.Collections;

public class EnvironmentType : MonoBehaviour {
	public static int worldType; 	//0 is map, 1 is city, 2 is village
	WindowManager window;
	// Use this for initialization
	void Start () {
		window = GameObject.Find ("Window").GetComponent<WindowManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeWorld(int i){
		if (window.windowOpen == false) {
			Application.LoadLevel (i);
		}
	}
}