﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorldMovement : MonoBehaviour {
	public GameObject cameraBox;
	public int xCord;
	public int yCord;
	WorldSavedCoordinates saveData;
	// Use this for initialization
	void Start () {
		GameObject data = GameObject.Find ("World Data Storage");
		saveData = data.GetComponent<WorldSavedCoordinates> ();
		xCord = saveData.GetCurrentLocationX();
		yCord = saveData.GetCurrentLocationY();
		positionMovement ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void positionMovement(){
		Transform cameraTransform = cameraBox.GetComponent<Transform> ();
		cameraTransform.position = new Vector3(xCord, 1, yCord);
		saveData.SetCurrentLocation (xCord, yCord);
	}
	public void SetPosition(int x, int y){
		xCord = x;
		yCord = y;
		positionMovement ();
	}
	public void xChange(){
		GameObject xBox = GameObject.Find ("X-Cord");
		InputField input = xBox.GetComponent<InputField> ();
		if (input.text != null){
			xCord = int.Parse (input.text);
		}
	}
	public void yChange(){
		GameObject xBox = GameObject.Find ("Y-Cord");
		InputField input = xBox.GetComponent<InputField> ();
		yCord = int.Parse (input.text);
	}
}