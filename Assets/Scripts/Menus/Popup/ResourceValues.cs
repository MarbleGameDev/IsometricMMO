using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceValues : MonoBehaviour {
	ResourceData popup;
	// Use this for initialization
	void Start () {
		popup = GameObject.Find("Resource Values").GetComponent<ResourceData>();

	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name.Equals ("FoodValues")) {
			gameObject.GetComponent<Text>().text = popup.GetFood().ToString();
		}
		if (gameObject.name.Equals ("WoodValues")) {
			gameObject.GetComponent<Text>().text = popup.GetWood().ToString();
		}
		if (gameObject.name.Equals ("MetalValues")) {
			gameObject.GetComponent<Text>().text = popup.GetMetal().ToString();
		}
		if (gameObject.name.Equals ("StoneValues")) {
			gameObject.GetComponent<Text>().text = popup.GetStone().ToString();
		}

		if (gameObject.name.Equals ("FoodChange")) {
			if (popup.GetFoodChange() >= 0){
				gameObject.GetComponent<Text>().text = "+" + popup.GetFoodChange().ToString();
			}else if (popup.GetFoodChange() < 0){
				gameObject.GetComponent<Text>().text = "-" + popup.GetFoodChange().ToString();
			}else if (popup.GetFoodChange() == 0){
				gameObject.GetComponent<Text>().text = "" + popup.GetFoodChange().ToString();
			}
		}
		if (gameObject.name.Equals ("WoodChange")) {
			if (popup.GetWoodChange() >= 0){
				gameObject.GetComponent<Text>().text = "+" + popup.GetWoodChange().ToString();
			}else if (popup.GetWoodChange() < 0){
				gameObject.GetComponent<Text>().text = "-" + popup.GetWoodChange().ToString();
			}else if (popup.GetWoodChange() == 0){
				gameObject.GetComponent<Text>().text = "" + popup.GetWoodChange().ToString();
			}
		}
		if (gameObject.name.Equals ("MetalChange")) {
			if (popup.GetMetalChange() >= 0){
				gameObject.GetComponent<Text>().text = "+" + popup.GetMetalChange().ToString();
			}else if (popup.GetMetalChange() < 0){
				gameObject.GetComponent<Text>().text = "-" + popup.GetMetalChange().ToString();
			}else if (popup.GetMetalChange() == 0){
				gameObject.GetComponent<Text>().text = "" + popup.GetMetalChange().ToString();
			}
		}
		if (gameObject.name.Equals ("StoneChange")) {
			if (popup.GetStoneChange() >= 0){
				gameObject.GetComponent<Text>().text = "+" + popup.GetStoneChange().ToString();
			}else if (popup.GetStoneChange() < 0){
				gameObject.GetComponent<Text>().text = "-" + popup.GetStoneChange().ToString();
			}else if (popup.GetStoneChange() == 0){
				gameObject.GetComponent<Text>().text = "" + popup.GetStoneChange().ToString();
			}
		}
	}
}
