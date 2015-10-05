using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WindowCloser : MonoBehaviour {
	WindowManager window;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Button>().onClick.AddListener(() => { click(); });
		window = GameObject.Find ("Window").GetComponent<WindowManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void click (){
		Debug.Log ("Click");
		window.CloseWindow ();
	}
}
