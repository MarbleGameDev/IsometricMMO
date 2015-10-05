using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TroopValues : MonoBehaviour {
	TroopData data;
	// Use this for initialization
	void Start () {
		data = GameObject.Find ("Troop Numbers").GetComponent<TroopData> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name.Equals ("WorkerValues")) {
			gameObject.GetComponent<Text>().text = data.GetWorkers().ToString();
		}
		if (gameObject.name.Equals ("WarriorValues")) {
			gameObject.GetComponent<Text>().text = data.GetWarriors().ToString();
		}
		if (gameObject.name.Equals ("ArcherValues")) {
			gameObject.GetComponent<Text>().text = data.GetArchers().ToString();
		}
		if (gameObject.name.Equals ("PikemenValues")) {
			gameObject.GetComponent<Text>().text = data.GetPikemen().ToString();
		}
		if (gameObject.name.Equals ("ScoutValues")) {
			gameObject.GetComponent<Text>().text = data.GetScouts().ToString();
		}
	}
}
