using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour {
	public static int WindowType = 0; 	//1 for resources, 2 for troops, 3 for notifications, 0 for nothing
	GameObject resources, troops, notifications;
	WindowManager window;
	void Start () {
		resources = GameObject.Find ("Resources");
		troops = GameObject.Find ("Troops");
		notifications = GameObject.Find ("Notifications");
		window = GameObject.Find ("Window").GetComponent<WindowManager> ();
		Visibility ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SwitchWindowType (int x){
		if (window.windowOpen == false) {
			if (WindowType == x) {
				WindowType = 0;
			} else {
				WindowType = x;
			}
			Visibility ();
		}

	}
	public int GetWindowType(){
		return WindowType;
	}
	public void Visibility(){
		if (WindowType != 0) {
			gameObject.SetActive(true);
			//Toggle the gameobjects
			switch (WindowType){
				case 1:
					resources.SetActive(true);
					troops.SetActive(false);
					notifications.SetActive(false);
					break;
				case 2:
					resources.SetActive(false);
					troops.SetActive(true);
					notifications.SetActive(false);
					break;
				case 3:
					resources.SetActive(false);
					troops.SetActive(false);
					notifications.SetActive(true);
					break;
				default:
					break;
			}
		}else{
			gameObject.SetActive(false);
		}
	}
}
