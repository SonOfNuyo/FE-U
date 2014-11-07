using UnityEngine;
using System.Collections;

public class Forest : Tile {

	public override TerrainType terrainType {
		get {
			return TerrainType.Forest;
		}
		set {
			//Something might transform a tile's type
			terrainType = value;
		}
	}

	public override Vector2 defenseBonus { get{return defenseBonus;} set{ defenseBonus = value; } }
	public override Vector2 resistanceBonus { get{return resistanceBonus;} set{ resistanceBonus = value; } }
	public override Vector2 avoidBonus { get{return avoidBonus;} set{ avoidBonus = value; } }
	public override Vector2 moveCost { get{return moveCost;} set{ moveCost = value; } }
	
	private static Vector2 OGDefense = new Vector2 (1f, 0f);
	private static Vector2 OGResistance = new Vector2 (2f, 0f);
	private static Vector2 OGAvoid = new Vector2 (15f, 0f);
	private static Vector2 OGMove = new Vector2 (2f, 1f);

	public override bool attackable {get {return true;}}
	public override bool blocksAttacks {
		get {return blocksAttacks;}
		set {blocksAttacks = value;}
	}

	// Use this for initialization
	void Start () {
		defenseBonus = OGDefense;
		resistanceBonus = OGResistance;
		avoidBonus = OGAvoid;
		moveCost = OGMove;
		blocksAttacks = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override int MovementCost (MovementType mv)
	{
		switch (mv) {
		case MovementType.Ground:
			return (int) moveCost.x;
		case MovementType.Flying:
			return (int) moveCost.y;
		case MovementType.Heavy:
			return (int) moveCost.x;
		case MovementType.Mage:
			return (int) moveCost.x;
		case MovementType.Mounted:
			return (int) moveCost.x;
		}
		return (int) moveCost.x;
	}
}
