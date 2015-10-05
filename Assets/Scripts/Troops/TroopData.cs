using UnityEngine;
using System.Collections;

public class TroopData : MonoBehaviour {
	public static int warriors, workers, archers, pikemen, scouts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeWarriors(int x){
		warriors += x;
	}
	public void ChangeWorkers(int x){
		workers += x;
	}
	public void ChangeArchers(int x){
		archers += x;
	}
	public void ChangePikemen(int x){
		pikemen += x;
	}
	public void ChangeScouts(int x){
		scouts += x;
	}

	public int  GetWarriors(){
		return warriors;
	}
	public int GetWorkers(){
		return workers;
	}
	public int GetArchers(){
		return archers;
	}
	public int GetPikemen(){
		return pikemen;
	}
	public int GetScouts(){
		return scouts;
	}
}
