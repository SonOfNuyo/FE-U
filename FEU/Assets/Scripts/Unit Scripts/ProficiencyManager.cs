using UnityEngine;
using System.Collections;

public class ProficiencyManager : MonoBehaviour {

	public weaponRanks[] weaponProfs = new weaponRanks[12];
	public int[] weaponExp = new int[12];
	public weaponTypes SRankWeapon;

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
