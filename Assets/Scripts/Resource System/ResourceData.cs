using UnityEngine;
using System.Collections;

public class ResourceData : MonoBehaviour {
	public static int food = 0, wood = 0, metal = 0, stone = 0;
	public static int foodChange = 7804, woodChange = 30, metalChange = 94, stoneChange = 70;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("UpdateValues", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void UpdateValues(){
		wood += woodChange;
		food += foodChange;
		metal += metalChange;
		stone += stoneChange;
	}

	public int GetFood(){
		return food;
	}
	public void ChangeFood(int x){
		food += x;
	}

	public int GetWood(){
		return wood;
	}
	public void ChangeWood(int x){
		wood += x;
	}

	public int GetMetal(){
		return metal;
	}
	public void ChangeMetal(int x){
		metal += x;
	}

	public int GetStone(){
		return stone;
	}
	public void ChangeStone(int x){
		stone += x;
	}

	public void SetFoodChange(int x){
		foodChange = x;
	}
	public void SetWoodChange(int x){
		woodChange = x;
	}
	public void SetMetalChange(int x){
		metalChange = x;
	}
	public void SetStoneChange(int x){
		stoneChange = x;
	}

	public void ChangeFoodChange(int x){
		foodChange += x;
	}
	public void ChangeWoodChange(int x){
		woodChange += x;
	}
	public void ChangeMetalChange(int x){
		metalChange += x;
	}
	public void ChangeStoneChange(int x){
		stoneChange += x;
	}

	public int GetFoodChange(){
		return foodChange;
	}
	public int GetWoodChange(){
		return woodChange;
	}
	public int GetMetalChange(){
		return metalChange;
	}
	public int GetStoneChange(){
		return stoneChange;
	}
}