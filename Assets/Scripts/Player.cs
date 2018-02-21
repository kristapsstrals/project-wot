using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: use an interface for ICharacter that all cahracters (monsters, player) can share (mana, hp, stamina etc.)

public class Player : MonoBehaviour {

	public float Hp = 10f;
	public float Mana = 10f;
	public float Stamina = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CastSkill(15, "spell");
	}

	void CastSkill(float cost, string type) //Pass in the skill
	{
		// Main idea - use a spell if you know it, but if you're a novice, you risk killing yourself
		// Similarly, over exhausting yourself hits into Hp
		if (Input.GetMouseButtonDown(0)){
			float remaining = type == "spell" 
				? Mana - cost
				: Stamina - cost;
			
			if (remaining < 0){
				Hp += remaining;

				if (Hp < 0){
					print("You are dead!");
				}
			}
		}

	}
}
