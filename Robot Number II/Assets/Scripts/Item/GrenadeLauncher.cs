﻿using UnityEngine;
using System.Collections;

public class GrenadeLauncher : IItem {

	private string item = "GrenadeLauncher";
	private string slot = "weapon";
	private IAbility primary = new BasicAttack("Projectile", 0f, 5f, 10f, 10f, 0.2f);
	private IAbility secondary = new GrenadeToss(100f,100f,200f,200f,10f);
	private bool isOwned = false;
	private int price = 20;

	public GrenadeLauncher (){}

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

	public bool IsOwned(){
		return this.isOwned;
	}

	public int GetPrice(){
		return this.price;
	}

	public void Buy(){
		this.isOwned = true;
	}

	public string GetTooltip(){
		string tooltip = this.item + "\n";
		tooltip += "Projectile shoot, Grenade toss\n";
		tooltip += "PRICE: " + this.price + "\n";
		if (this.isOwned)
			tooltip += "OWNED";
		else
			tooltip += "NOT OWNED";

		return tooltip;
	}


}
