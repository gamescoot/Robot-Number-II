﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	private GameObject enemy;
	private RectTransform trans;
	private float characterHeight = 40f;
	
	// Use this for initialization
	void Start () {
		this.trans = (RectTransform)this.transform.parent;

	}
	
	// Update is called once per frame
	void Update () {
		if (this.enemy != null) {
			Image image = GetComponent<Image> ();
			Vector3 cpos = Camera.main.WorldToViewportPoint (this.enemy.transform.position);
			
			this.transform.position = new Vector3 (this.trans.position.x + cpos.x * this.trans.rect.width - this.trans.sizeDelta.x / 2, this.trans.position.y + cpos.y * this.trans.rect.height - this.trans.sizeDelta.y / 2 + this.characterHeight);
			image.fillAmount = this.enemy.gameObject.GetComponentInChildren<ICharacter> ().GetDefense ().GetShield () / 50f;
		}


	}

	public void SetObj(GameObject enemy){
		this.enemy = enemy;
	}
}
