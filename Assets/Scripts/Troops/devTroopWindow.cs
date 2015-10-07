using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class devTroopWindow : MonoBehaviour {
	public Text Workers;
	public Text Warriors;
	public Text Archers;
	public Text Pikemen;
	public Text Scouts;
	public Text Workers2;
	public Text Warriors2;
	public Text Archers2;
	public Text Pikemen2;
	public Text Scouts2;
	BattleCalculations battle;
	int[] player1 = {0,0,0,0,0};
	int[] player2 = {0,0,0,0,0};
	int[] player1Result = {0,0,0,0,0};
	int[] player2Result = {0,0,0,0,0};
	// Use this for initialization
	void Start () {
		battle = GetComponent<BattleCalculations> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ButtonClick(){
		GatherTroopNumbers ();
		battle.SetPlayer1 (player1);
		battle.SetPlayer2 (player2);
		int winner = battle.Battle ();
		player1Result = battle.GetPlayer1 ();
		player2Result = battle.GetPlayer2 ();
		SetTroopNumbers ();
		Debug.Log (winner);
	}
	public void GatherTroopNumbers(){
		player1 [0] = int.Parse (Workers.text);
		player1 [1] = int.Parse (Warriors.text);
		player1 [2] = int.Parse (Archers.text);
		player1 [3] = int.Parse (Pikemen.text);
		player1 [4] = int.Parse (Scouts.text);
		player2 [0] = int.Parse (Workers2.text);
		player2 [1] = int.Parse (Warriors2.text);
		player2 [2] = int.Parse (Archers2.text);
		player2 [3] = int.Parse (Pikemen2.text);
		player2 [4] = int.Parse (Scouts2.text);
	}
	public void SetTroopNumbers (){ 	//Fuck this Shit, I need to change the whole fucking thing from Text to InputField and use value instead of Text
		Workers.text = player1Result [0].ToString();
		Warriors.text = player1Result [1].ToString();
		Archers.text = player1Result [2].ToString();
		Pikemen.text = player1Result [3].ToString();
		Scouts.text = player1Result [4].ToString();
		Workers2.text = player2Result [0].ToString();
		Warriors2.text = player2Result [1].ToString();
		Archers2.text = player2Result [2].ToString();
		Pikemen2.text = player2Result [3].ToString();
		Scouts2.text = player2Result [4].ToString();
	}
}