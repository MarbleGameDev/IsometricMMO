﻿using UnityEngine;
using System.Collections;

public class WorldSavedCoordinates : MonoBehaviour {
	public static int currentLocationX = 0;
	public static int currentLocationY = 0;
	public static int[,] cities = {{0, 0}}; 	//for [i, x], i is the city identifier, x as 0 is x coord, and x as 1 is y coord
	public static string[] cityNames = {""}; 	//for []
	public static int[,] savedLocations = {{2,2}}; 	//for [i, x], i is the city identifier, x as 0 is x coord, and x as 1 is y coord
	public static string[] locationNames = {"2 Squared"};
	public bool initFinished = false;

	void Awake(){
		//Code to initialize values from storage here
	}
	// Use this for initialization
	void Start () { 
		initFinished = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetCurrentLocation(int x, int y){
		currentLocationY = y;
		currentLocationX = x;
	}
	public void SetCities(int index, int x, int y){
		cities [index, 0] = x;
		cities [index, 1] = y;
	}
	public void SetCityName(int index, string name){
		cityNames [index] = name;
	}
	public void SetSavedLocations(int index, int x, int y){
		savedLocations [index, 0] = x;
		savedLocations [index, 1] = y;
	}
	public void SetLocationName(int index, string name){
		locationNames [index] = name;
	}

	public int GetCurrentLocationX(){
		return currentLocationX;
	}
	public int GetCurrentLocationY(){
		return currentLocationY;
	}
	public int[,] GetSavedLocations(){
		return savedLocations;
	}
	public string GetLocationName(int index){
		return locationNames[index];
	}
}
