using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RescuePairUpManager : MonoBehaviour {

	public List<Stat> pairBonus;
	public List<Stat> rescuePenalty;

	public Character pairUpPartner;
	public Character rescueTarget;

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
