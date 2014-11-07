using UnityEngine;
using System.Collections;

public class Support : MonoBehaviour {

	public SupportRank rank;				//Current rank of conversation
	public Character firstPerson;			//Who are the two people
	public Character secondPerson;			//part of the support?

	public int[] supportConvo;				//This represents the locations of the support conversations, type may vary based on dialogue system used.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
