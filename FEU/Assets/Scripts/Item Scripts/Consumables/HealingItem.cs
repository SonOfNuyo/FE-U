using UnityEngine;
using System.Collections;

public class HealingItem : Consumable {

	public float healingAmount;			//How much to heal
	public bool flatAmount = true;		//If true, heals a flat amount, otherwise heals a percentage

	public override void UseItem ()
	{
		throw new System.NotImplementedException ();
	}
}
