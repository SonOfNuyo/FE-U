using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapon : Item {

	public weaponTypes type;
	public weaponRanks rank;	//E, D, C, B, A, S 1-6

	//Weapon stats
	public int Might;		//Attack of weapon
	public int Hit;			//Accuracy of weapon
	public int Crit;		//Bonus crit chance of weapon
	public int maxRange;	//Max range of weapon
	public int minRange;	//Minimum range of weapon
	public int maxUses;		//Max durability of weapon, if -9999 it is infinite
	public int currUses;	//Current durability of weapon, will be set to -9999 of max is -9999.

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
