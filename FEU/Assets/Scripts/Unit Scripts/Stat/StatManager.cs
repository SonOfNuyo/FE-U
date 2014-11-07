using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatManager : MonoBehaviour {

	public List<Stat> stats;		//Place which stats this character uses here
	[HideInInspector] public Character owner;
	[HideInInspector] List<Stat> classStats;	//Assign the class stats here so they can be added to the character's stats

	public int move = 6;				//How far a character can move, default 6

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
