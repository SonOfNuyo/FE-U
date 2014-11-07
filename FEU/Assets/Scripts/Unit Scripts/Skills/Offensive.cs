using UnityEngine;
using System.Collections;

public abstract class Offensive : Skill {

	public int activationChance;			//Chance for skill to activate if defensive or offensive
	public Character target;				//Offensive skills are usually used on the target if activated

	public override abstract void SkillEffect();

	public override bool Equals (object o)
	{
		return base.Equals (o);
	}

	public override int GetHashCode ()
	{
		return base.GetHashCode ();
	}
}
