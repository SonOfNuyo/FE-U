using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Tile : MonoBehaviour {

	public int xCord = -1;
	public int yCord = -1;

	public abstract TerrainType terrainType { get; set; }

	//the X should be for ground units, Y for flying units
	//External skills can modify these values for the unit
	//Like a pirate with Swim would reduce movecost Ground to 2 for him/herself
	public abstract Vector2 defenseBonus { get; set; }
	public abstract Vector2 resistanceBonus { get; set; }
	public abstract Vector2 avoidBonus { get; set; }
	public abstract Vector2 moveCost { get; set; }

	public abstract bool attackable{ get;}
	public abstract bool blocksAttacks{ get; set; }

	[HideInInspector]public List<Tile> adjTiles;

	public virtual void EndOfTurn(){			//Actions tiles should perform at certain turn times
	}			
	public virtual void BeginningOfTurn(){		//Like fortresses healing units
	}

	public abstract int MovementCost (MovementType mv);

	public Character occupyingUnit;

	// Use this for initialization
	void Start () {
		setAdjTiles ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void setAdjTiles(){

		adjTiles.Clear ();
		Grid map = GetComponentInParent<Grid> ();

		if (xyToArrayIndex (xCord - 1, yCord) >= 0 && xyToArrayIndex (xCord - 1, yCord) < map.tiles.Count)
		adjTiles.Add (map.tiles [xyToArrayIndex (xCord - 1, yCord)].GetComponent<Tile>());

		if (xyToArrayIndex (xCord + 1, yCord) >= 0 && xyToArrayIndex (xCord + 1, yCord) < map.tiles.Count)
		adjTiles.Add (map.tiles [xyToArrayIndex (xCord + 1, yCord)].GetComponent<Tile>());

		if (xyToArrayIndex (xCord, yCord - 1) >= 0 && xyToArrayIndex (xCord, yCord - 1) < map.tiles.Count)
		adjTiles.Add (map.tiles [xyToArrayIndex (xCord, yCord - 1)].GetComponent<Tile>());

		if (xyToArrayIndex (xCord, yCord + 1) >= 0 && xyToArrayIndex (xCord, yCord + 1) < map.tiles.Count)
		adjTiles.Add (map.tiles [xyToArrayIndex (xCord, yCord + 1)].GetComponent<Tile>());

	}

	int xyToArrayIndex(int x, int y){
		return ((y * Grid.tileHeight) + x);
	}

	void OnDrawGizmos(){

		if (xCord == -1 && yCord == -1) 
			if ( GetComponent<CoordStore>() != null){
				xCord = GetComponent<CoordStore>().xCord;
				yCord = GetComponent<CoordStore>().yCord;
		}

		if (occupyingUnit != null)
			occupyingUnit.transform.position = new Vector3 (transform.position.x, transform.position.y, occupyingUnit.transform.position.z);

		Gizmos.DrawSphere (transform.position, .01f);
		Gizmos.DrawWireCube(transform.position, new Vector3 (.16f, .16f, 0f));
	}
}
