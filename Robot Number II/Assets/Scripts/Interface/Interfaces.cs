﻿using UnityEngine;
using System.Collections;

public interface ICharacter{
	
	void Die();
	void SetGrounded(bool grounded);
	void SetCanClimb(bool canClimb);
	void SetGravity(float grav);
	int GetDirection();
	string GetTag();
	Vector3 GetPosition();
	bool GetCanClimb();

	void ApplyAbility(IAbility ability);
	void AddEffect(IEffect effect);
	void CalculateSpeed();
	void EffectExpiration();
	IDefenseBehavior GetDefense();
}

abstract public class Nondamageable{
	
	public void ApplyAbility(IAbility ability){}

}