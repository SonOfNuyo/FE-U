using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillManager : MonoBehaviour {

	public int skillPoints = 0;				//Each skill takes a different number of points, 
	public int skillCap = 1; 				//A unit cannot surpass their cap when learning skills.
	public List<Passive> passiveSkills;
	public List<Offensive> offensiveSkills;
	public List<Defensive> defensiveSkills;
	[HideInInspector] public Character owner;

	//Activates the first successful skill activated (offense)
	public bool rollForSkillsOffensive(){

		return false;
	}

	//Activates the first successful skill activated (defense)
	public bool rollForSkillsDefensive(){

		return false;
	}

	//Allows you to add a skill to the manager, such as through an item or event
	//Returns true if successful, false if not
	public bool AddSkill(Skill newSkill){

		//Skill point cap exceeded, return fail
		if (skillPoints + newSkill.skillPoints >= skillCap) {return false;}
		//Already know the skill, return fail
		if (checkDuplicates (newSkill)) {return false;}
		//If the skill object doesn't have an owner, automatically fail
		if (owner == null) {return false;}

		//Add to correct skill list
		switch (newSkill.type) {

		case skillType.Passive:
			passiveSkills.Add((Passive)newSkill);
			break;
		case skillType.Offensive:
			offensiveSkills.Add((Offensive)newSkill);
			break;
		case skillType.Defensive:
			defensiveSkills.Add((Defensive)newSkill);
			break;
		}

		newSkill.transform.parent = this.transform;
		//Skill added successfully
		skillPoints += newSkill.skillPoints;
		return true;
	}

	//Remove skill from list
	public bool RemoveSkill(Skill oldSkill){

		//Remove from correct skill list
		switch (oldSkill.type) {
			
		case skillType.Passive:
			passiveSkills.Remove((Passive)oldSkill);
			break;
		case skillType.Offensive:
			offensiveSkills.Remove((Offensive)oldSkill);
			break;
		case skillType.Defensive:
			defensiveSkills.Remove((Defensive)oldSkill);
			break;
		}

		skillPoints -= oldSkill.skillPoints;
		//Skill object should be removed
		Destroy (oldSkill.gameObject);
		return true;
	}

	//This function will make sure you don't already know the skill
	private bool checkDuplicates(Skill newSkill){

		if (passiveSkills.Contains ((Passive)newSkill))		return true;
		if (offensiveSkills.Contains((Offensive) newSkill)) return true;
		if (defensiveSkills.Contains((Defensive) newSkill)) return true;

		return false;
	}
	
}
