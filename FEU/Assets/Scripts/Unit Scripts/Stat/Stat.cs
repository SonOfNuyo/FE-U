using UnityEngine;
using System.Collections;

public class Stat : MonoBehaviour {

	public string statName;		//Name of the stat
	public string statDesc;		//Describes the stat
	public stats statType;

	public float cap = 20;					//The maximum the stat can achieve
	[HideInInspector] public float min = 0;	//Can the stat go below 0?
	public float current = 0;				//The current stat value
	public float bonus = 0;					//Bonus stats in green from gear or skills

	public float currValue;					//If a stat gets impacted negatively (especially HP), track it here

	public float growthRate = 0;			//Chance as a percent to increase this stat on level up

	public void Increment(){
				current++;
		}
	public void Decrement(){
				current--;
		}

	public void Set(float newValue){
		current = Mathf.Clamp (newValue, min, cap);
	}

	//Level up the stat when the character levels up!
	public void LevelUp(){

		float currentRate = growthRate;
		while (currentRate > 0) {
			float tempRate = Mathf.Min (currentRate, 100f);
			float d100 = Random.Range(0f, 100f);
			if (d100 <= tempRate){
				Increment();
			}

			currentRate -= 100f;

		}
	}

}
