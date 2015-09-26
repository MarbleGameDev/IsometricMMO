using UnityEngine;
using System.Collections;

public class WorldLoad : MonoBehaviour {
	WorldSavedCoordinates saveData;
	WorldMovement movement;
	// Use this for initialization
	void Start () {
		if (Application.loadedLevel == 0) {
			PopulateWorld();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PopulateWorld(){

	}
}
