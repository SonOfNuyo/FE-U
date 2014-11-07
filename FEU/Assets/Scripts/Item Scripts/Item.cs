using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour {

	public string itemName;		//Item's name, obviously
	public string description;	//The text description associated with the item

	public int buyValue;		//How much is the item worth to buy
	public int sellValue;		//To sell?

	public Texture2D icon;		//Picture of the item in question

	public bool thiefProne;		//Can it be stolen?

	public List<Skill> bonusOffensiveSkills;	//Items can grant extra skills
	public List<Skill> bonusDefensiveSkills;	//Defensive ones as well
	public int[] bonusStats = new int[8];		//And even extra stats
	
	public bool equipped;		//Is the item equipped?
	public Character owner;		//Who is holding the item? 
	
	//Loads Weapon data to be used in the current level.
	//Only load at the start of the chapter.
	void LoadData () {
	}
	
	//Stores Weapon data to be used in other levels.
	//Only save at the end of the chapter.
	void SaveData() {
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
