using UnityEngine;
using System.Collections;

public enum stats{
	HP = 0,
	Strength = 1,
	Magic = 2,
	Skill = 3,
	Speed = 4,
	Luck = 5,
	Defense = 6,
	Resistance = 7,
	Move = 8
};

public enum weaponTypes{
	None = -1,
	Unarmed = 0,
	Sword = 1,
	Axe = 2,
	Lance = 3,
	Bow = 4,
	NonElemental = 5,
	Wind = 6,
	Fire = 7,
	Thunder = 8,
	Light = 9,
	Dark = 10,
	Staff = 11,
};

//[SerializeField]
public enum weaponRanks{
	U = 0, //Unused
	E = 1,
	D = 2,
	C = 3,
	B = 4,
	A = 5,
	S = 6,
};

public enum skillType {
	Passive,
	Defensive,
	Offensive
};

public enum TerrainType{
	Impassable = 0,
	Plains = 1,
	Forest = 2,
	Mountain = 3,
	Peak = 4,
	Fort = 5,
	Throne = 6,
	Ocean = 7,
	Desert = 8,
	River = 9,
	Pillar = 10,
	Bridge = 11,
	Snag = 12,
	Tree = 13,
	House = 14,
	Village = 15,
};

public enum charType{
	Normal = 0,
	Pegasus = 1,
	Wyvern = 2,
	Dragon = 3,
	Armored = 4,
	Beast = 5,
};

public enum MovementType{
	Ground = 0,
	Flying = 1,
	Mage = 2,
	Heavy = 3, 
	Mounted = 4
}

public enum SupportRank{
	D = 0,
	C = 1,
	B = 2,
	A = 3,
	S = 4,
};

public enum Affinity{
	Anima,
	Dark,
	Light,
	Fire,
	Ice,
	Thunder,
	Wind,
};

public enum Status{
	Poison,
	Curse,
	Berserk,
	Sleep,
	Stun,
	Confusion,
};