﻿using UnityEngine;
using System.Collections;

public class RushAnim : MonoBehaviour, IAnim {

	private bool isRush = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (isRush) {
			GameObject proj = (GameObject)Instantiate (Resources.Load ("Rush"));
			proj.transform.position = this.transform.position;
			this.isRush = false;
		}
	}

	public void Animate(IAbility ability, ICharacter character){
		this.isRush = true;
	}
}
