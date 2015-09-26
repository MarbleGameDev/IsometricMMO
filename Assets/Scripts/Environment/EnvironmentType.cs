using UnityEngine;
using System.Collections;

public class EnvironmentType : MonoBehaviour {
	public int worldType; 	//0 is map, 1 is city, 2 is village
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeWorld(int i){
		Application.LoadLevel (i);
	}
}