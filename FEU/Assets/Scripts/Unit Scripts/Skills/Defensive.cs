using UnityEngine;
using System.Collections;

public abstract class Defensive : Skill {

	public int activationChance;			//Chance for skill to activate if defensive or offensive
	public override abstract void SkillEffect();		//Defensive skills should affect the Skill Owner only!

	public override bool Equals (object o)
	{
		return base.Equals (o);
	}

	public override int GetHashCode ()
	{
		return base.GetHashCode ();
	}
	
}
