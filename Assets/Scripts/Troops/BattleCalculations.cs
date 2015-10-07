using UnityEngine;
using System.Collections;

public class BattleCalculations : MonoBehaviour {
	//for the int arrays, indexs are as follows:
	//0 is workers, 1 is warriors, 2 is archers, 3 is pikemen, 4 is scouts 
	int[] player1Result = {0,0,0,0,0};
	int[] player2Result = {0,0,0,0,0};
	int[] player1 = {0,0,0,0,0};
	int[] player2 = {0,0,0,0,0};
	int[] troopAttack = {2, 8, 10, 12, 1};
	int[] troopDefense = {5, 10, 6, 12, 1};
	int[] troopRange = {2, 3, 10, 5, 1};
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public BattleCalculations returnClass(){
		return this;
	}

	public void SetPlayer1(int[] player){
		player1 = player;
	}
	public void SetPlayer2(int[] player){
		player2 = player;
	}

	public int[] GetPlayer1(){
		return player1Result;
	}
	public int[] GetPlayer2(){
		return player2Result;
	}

	public int Battle(){
		int player1Sum = 0;
		int player2Sum = 0;
		foreach (int number in player1){
			player1Sum += number;
		}
		foreach (int number in player2) {
			player2Sum += number;
		}
		if (player1Sum > player2Sum) {
			return 1;
		} else if (player2Sum > player1Sum) {
			return 2;
		} else if (player1Sum == player2Sum) {
			return 0;
		}
		return 0; 	//Return int for number of player that wins.
	}
}
