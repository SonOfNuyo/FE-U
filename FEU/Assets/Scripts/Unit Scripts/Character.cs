using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	public string characterName;		//Name of the character
	public Class characterClass;		//Character's current class
	
	public int exp;						//When you get 100, you level up.
	public int effectiveLevel;			//If a character class changes multiple times, their effective level keeps increasing

	//Stat Manager object should be a child of the character object
	public StatManager statManager;

	//Item manager object should be a child of the character object
	public InventoryManager itemManager;
	
	public Affinity affinity;			//A characters elemental affinity can affect different things
	public List<charType> CharTypes;
	public List<StatusEffect> statusEffects;

	//Gain 100 weapon exp to rank up, ranks go from E to S
	//Only one weapon type can have rank S 
	public ProficiencyManager weaponProfs;

	public AI ai = null;

	//Skill Manager object should be a child of the Character object
	public SkillManager charSkills;

	//Relations with other units
	public Support[] supports;

	//RescuePairUp Manager object should be a child of the Character object
	public RescuePairUpManager rescuePairUp;

	//UI and Visuals
	//They should be seperate objects (children of Character object)
	public Animator portraitAnimator;
	public Animator fieldAnimator;
	public Animator combatAnimator;
	public Sprite mug;
	public Sprite chibiMug;


	//Combat stat manager should be a child of the Character object
	public CombatStatManager combatManager;

	public Tile currentLocation;
	[HideInInspector]public List<Tile> possibleMoves;
	[HideInInspector]public List<Tile> possibleAttacks;

	public void checkMoves(){
	
		moveDLS (currentLocation.xCord, currentLocation.yCord, statManager.move);
		if (itemManager.equippedWeapon != null)
			attackDLS (currentLocation.xCord, currentLocation.yCord, itemManager.equippedWeapon.minRange, itemManager.equippedWeapon.maxRange);

	}

	private void moveDLS(int x, int z, int moveLeft)
	{
		possibleMoves.Clear ();
		if (moveLeft > 0)
		{
			foreach (Tile t in currentLocation.adjTiles){
				moveCheckTile(t, moveLeft);
			}
		}
	}
	
	private void moveCheckTile(Tile t, int moveLeft)
	{   
		if (t.MovementCost (characterClass.moveType) <= moveLeft) {
			if (!possibleMoves.Contains(t)){
				possibleMoves.Add(t);
				foreach (Tile tt in t.adjTiles){
					moveCheckTile(tt, moveLeft - t.MovementCost(characterClass.moveType));
				}
			}
		}
	}

	private void attackDLS(int x, int z, int minRange, int maxRange)
	{
		possibleAttacks.Clear ();
			foreach (Tile t in possibleMoves){
				attackCheckTile(t, 0, minRange, maxRange);
			}
		
	}
	
	private void attackCheckTile(Tile t, int distance, int minRange, int maxRange)
	{   
		if (distance <= maxRange && distance >= minRange) {
			if (!t.blocksAttacks && !possibleAttacks.Contains(t)){

				if (t.attackable)
					possibleAttacks.Add(t);
				foreach (Tile tt in t.adjTiles){
					attackCheckTile(tt, distance + 1, minRange, maxRange);
				}

			}
		}
	}

	// Use this for initialization
	void Start () {


	}

	//Loads character data to be used in the current level.
	//Only load at the start of the chapter.
	void LoadData () {
	}

	//Stores character data to be used in other levels.
	//Only save at the end of the chapter.
	void SaveData() {
	}
	

	// Update is called once per frame
	void Update () {
	
	}
}
