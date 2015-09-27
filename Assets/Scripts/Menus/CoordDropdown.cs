using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions{

public class CoordDropdown : MonoBehaviour {
		DropDownList dropList;
		WorldSavedCoordinates savedCoords;
		WorldMovement movement;
		int[,] coords;
	// Use this for initialization
	void Start () {
		dropList = GetComponent<DropDownList> ();
		savedCoords = GameObject.Find ("World Data Storage").GetComponent<WorldSavedCoordinates>();
			movement = GameObject.Find ("World Loading Object").GetComponent<WorldMovement> ();
			coords = savedCoords.GetSavedLocations ();
			int numLocations = coords.GetLength (0) - 1;
			//Debug.Log (numLocations);
			for (int i = 0; i <= numLocations; i++) {
				string locationName = savedCoords.GetLocationName(i);
				DropDownListItem newButton = new DropDownListItem (locationName);
				dropList.AddItems (newButton);
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void GetButtonClick(int indx){
			movement.SetPosition (coords[indx, 0], coords[indx, 1]);
	}
}
}