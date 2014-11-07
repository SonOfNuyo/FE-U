using UnityEngine;
using System.Collections;

public abstract class Passive : Skill {

	public bool inEffect;		//Is the passive already in effect?  If not, toggle it on!

	public override abstract void SkillEffect();		//Passive skills 

	public override bool Equals (object o)
	{
		return base.Equals (o);
	}

	public override int GetHashCode ()
	{
		return base.GetHashCode ();
	}
}
