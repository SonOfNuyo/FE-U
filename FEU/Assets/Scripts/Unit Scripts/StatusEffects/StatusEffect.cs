using UnityEngine;
using System.Collections;

public abstract class StatusEffect : MonoBehaviour {
	
	public int turnsLeft;	//How many turns of the status are left
	public Status status;	//Which status is it

	public Character statusedPerson;	//Who is the person with the status effect.

	public void doEffect (){}			//Each status effect must have an effect on the statusedPerson.
}
