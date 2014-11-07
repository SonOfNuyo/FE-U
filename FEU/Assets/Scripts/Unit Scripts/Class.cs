using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Class : MonoBehaviour {

	public string className;			//Class's name
	public int level; 					//Level of current class.
	public MovementType moveType;

	//Combine these stats with the stat manager ones.
	public List<Stat> bonuses;

	//Certain classes are better at certain weapons, but a unit can use any weapon they have ranks
	//If the weapon is not ranked, then it receives a penalty (clashes with class role)
	//Refer to weapon types Order in enums
	public weaponRanks[] weaponFoci = new weaponRanks[12];

	public Class[] promotionPaths;		//If the class can promote, put the options here

	//Owner object
	[HideInInspector] public Character owner;

	// Use this for initialization
	void Start () {
	
		if (owner == null) {
			owner = GetComponentInParent<Character>();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
