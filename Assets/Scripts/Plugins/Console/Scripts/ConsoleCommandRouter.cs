using UnityEngine;
using System.Collections;
using System;

public class ConsoleCommandRouter : MonoBehaviour {
	DevOptions dev;
	GameObject console;
	public GameObject resourceValues;
	public GameObject troopNumbers;
	public GameObject window;
	WindowManager windowManager;
	ResourceData resourceData;
	TroopData troopData;
	// Use this for initialization
	void Start () {
		console = GameObject.Find ("Console");
		dev = console.GetComponent<DevOptions>();
		resourceData = resourceValues.GetComponent<ResourceData> ();
		troopData = troopNumbers.GetComponent<TroopData> ();
		windowManager = window.GetComponent<WindowManager> ();
		var repo = ConsoleCommandsRepository.Instance;
		repo.RegisterCommand ("changetroops", ChangeTroops);
		repo.RegisterCommand ("closewindow", CloseWindow);
		repo.RegisterCommand ("debug", DebugOn);
		repo.RegisterCommand ("exit", Exit);
		repo.RegisterCommand ("foodrate", FoodRate);
		repo.RegisterCommand("help", Help);
		repo.RegisterCommand("load", Load);
		repo.RegisterCommand ("metalrate", MetalRate);
		repo.RegisterCommand ("openwindow", OpenWindow);
		repo.RegisterCommand ("stonerate", StoneRate);
		repo.RegisterCommand ("woodrate", WoodRate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public string CloseWindow (params string[] args){
		windowManager.CloseWindow ();
		return "";
	}
	public string OpenWindow (params string[] args){
		windowManager.OpenWindow (args[0]);
		return "";
	}

	public string ChangeTroops (params string[] args){
		string troopName;
		int troopCount;
		try{
			troopName = args[0];
			troopCount = int.Parse(args[1]);
		} catch (Exception e){
			return "Invalid Arguements, use troop name followed by number";
		}
		switch (troopName){
		case "Workers":
		case "workers":
		case "Worker":
		case "worker":
			troopData.ChangeWorkers(troopCount);
			break;
		case "Warriors":
		case "warriors":
		case "Warrior":
		case "warrior":
			troopData.ChangeWarriors(troopCount);
			break;
		case "Archers":
		case "archers":
		case "Archer":
		case "archer":
			troopData.ChangeArchers(troopCount);
			break;
		case "Pikemen":
		case "pikemen":
		case "Pikeman":
		case "pikeman":
			troopData.ChangePikemen(troopCount);
			break;
		case "Scouts":
		case "scouts":
		case "Scout":
		case "scout":
			troopData.ChangeScouts(troopCount);
			break;
		}
		return "Troop Value Changed";
	}

	public string FoodRate(params string[] args){
		int value;
		try{
			value = int.Parse(args[0]);
			resourceData.SetFoodChange(value);
		} catch (Exception e){
			return "Invalid integer value";
		}
		return "Rate Changed";
	}
	public string WoodRate(params string[] args){
		int value;
		try{
			value = int.Parse(args[0]);
			resourceData.SetWoodChange(value);
		} catch (Exception e){
			return "Invalid integer value";
		}
		return "Rate Changed";
	}
	public string MetalRate(params string[] args){
		int value;
		try{
			value = int.Parse(args[0]);
			resourceData.SetMetalChange(value);
		} catch (Exception e){
			return "Invalid integer value";
		}
		return "Rate Changed";
	}
	public string StoneRate(params string[] args){
		int value;
		try{
			value = int.Parse(args[0]);
			resourceData.SetStoneChange(value);
		} catch (Exception e){
			return "Invalid integer value";
		}
		return "Rate Changed";
	}

	public string Exit(params string[] args){
		Application.Quit ();
		return "Closing Game";
	}

	public string Help(params string[] args){
		var repo = ConsoleCommandsRepository.Instance;
		repo.getDictionary ();
		return "";
	}

	public string Load(params string[] args) {
		String fileName;
		try{
			fileName = args[0];
		} catch (Exception e){
			return "Missing Level Name";
		}
		Application.LoadLevel(fileName);
		return "Loaded " + fileName;
	}
	


	public string DebugOn (params string[] args){
		String fileName;
		try{
			fileName = args[0];
		} catch (Exception e){
			return "Missing <true/false>";
		}
		if (fileName.Equals ("true")) {
			dev.debug = true;
		}
		if (fileName.Equals ("false")) {
			dev.debug = false;
		}
		return "Debug Set to: " + fileName;
	}
}
