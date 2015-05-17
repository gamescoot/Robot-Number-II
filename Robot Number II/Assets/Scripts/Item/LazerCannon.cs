﻿using UnityEngine;
using System.Collections;

public class LazerCannon : IItem {

	private string item = "LazerCannon";
	private string slot = "weapon";
	private IAbility primary = new BasicAttack("Lazer", 15f, 10f, 0f, 0f, 0.5f);
	private IAbility secondary = new DeathLazer(20f,10f,0f,0f,15f);

	public LazerCannon (){}

	public string GetItem(){
		return this.item;
	}

	public string GetSlot(){
		return this.slot;
	}

	public IAbility GetPrimaryAbility(){
		return this.primary;
	}

	public IAbility GetSecondaryAbility(){
		return this.secondary;
	}


}
