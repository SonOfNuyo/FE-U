using UnityEngine;
using System.Collections;


//ALL skills have these in common
public abstract class Skill : MonoBehaviour {

	public string skillName;				//Name of the skill

	public string skillDescription;			//Describes what the skill does

	public skillType type; 					//What kind of skill is it?

	public Texture2D icon;

	public Character owner;
	public int skillPoints;					//How many skill points does this skill take?

	public abstract void SkillEffect();

	public override bool Equals (object o)
	{
		Skill s = (Skill) o;

		if (o == null)	return false;

		return (skillName.Equals (s.skillName));
	}

	public override int GetHashCode(){
		unchecked
		{
			int hash = 17;
			
			hash = hash * 23 + skillName.GetHashCode();
			return hash;
		}
	}
	
}
