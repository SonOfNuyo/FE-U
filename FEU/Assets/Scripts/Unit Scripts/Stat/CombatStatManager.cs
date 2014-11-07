using UnityEngine;
using System.Collections;

public enum CombatStatType { Might, Crit, Defense, Avoid, Hit, CritAvoid, NumberOfAttacks, CombatSpeed
};

public class CombatStatManager : MonoBehaviour {

	public float[] combatStats = new float[8];
	[HideInInspector] public Character owner;


	public void CalculateStat (CombatStatType whichStat){



	}

}
