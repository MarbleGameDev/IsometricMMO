using UnityEngine;
using System.Collections;

public class WindowManager : MonoBehaviour {
	public Transform window;
	Transform newWindow;
	string currentWindowName;
	public Transform devTroopWindow;
	public bool windowOpen = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OpenWindow(string name){
		windowOpen = true;
		currentWindowName = name;
		switch (name) {
		case "devTroopWindow":
			newWindow = Instantiate(devTroopWindow);
			newWindow.SetParent(window, false);
			break;
		}
	}
	public void CloseWindow(){
		windowOpen = false;
		Destroy(GameObject.Find (currentWindowName + "(Clone)"));
	}
}