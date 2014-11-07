using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour {

	public int inventorySize = 5;		//Characters can carry different amounts of Items
	public List<Item> inventory;		//Actual inventory
	public Weapon equippedWeapon;  	//Characters can only equip one weapon by default
	public List<Equipment> equippedOther;	//Some characters have special equipment
	public Offhand offHand;				//Shields go here, as do offhand weapons granted by the Dual Wield skill

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
