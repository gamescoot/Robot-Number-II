﻿using UnityEngine;
using System.Collections;

public class FittingMenu : MonoBehaviour {
	
	private IItem weapon = new NonItem();
	private IItem defense = new NonItem();
	private IItem offense = new NonItem();
	private IItem utility = new NonItem();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {}

	public void Equip(IItem item){
		switch (item.GetSlot ()) {
		case "weapon":
			this.weapon = item;
			break;
		case "defense":
			this.defense = item;
			break;
		case "offense":
			this.offense = item;
			break;
		case "utility":
			this.utility = item;
			break;
		default:
			break;
		}
	}

	public string WeaponInfo(){
		string result = "";
		result += "WEAPON: " + this.weapon.GetItem () + "\n";
		result += "DEFENSE SYSTEM : " + this.defense.GetItem () + "\n";
		result += "OFFENSE SYSTEM : " + this.offense.GetItem () + "\n";
		result += "UTILITY : " + this.utility.GetItem () + "\n";

		return result;
	}

	public void SetAbility(){
		ICharacter character = gameObject.GetComponentInParent<ICharacter> ();
		CharacterAbility abilities = character.GetAbilities();
		abilities.SetAbility(this.weapon.GetPrimaryAbility(),0);
		abilities.SetAbility(this.weapon.GetSecondaryAbility(),1);
		abilities.SetAbility (this.defense.GetPrimaryAbility (), 2);
		abilities.SetAbility (this.offense.GetPrimaryAbility (), 3);
		abilities.SetAbility (this.utility.GetPrimaryAbility (), 4);

	}
	
}
