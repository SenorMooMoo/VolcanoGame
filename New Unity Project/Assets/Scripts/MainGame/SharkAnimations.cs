using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkAnimations : MonoBehaviour {

	Animation SharkoMove;
	public float SharkAttackTimer;
	public float AnimationDelay;


	void Awake() {
		SharkoMove = gameObject.GetComponent<Animation> ();
		SharkAttackTimer = Random.Range (3, 10);
		SharkoMove.Play ("SharkMoving");
		AnimationDelay = 300;
	}

	void Update () {
		if (Time.time >= SharkAttackTimer) {
			AnimationDelay -= 1;
			SharkoMove.Play ("Shark Attacking");
			print ("In State: Attacking");
			if (AnimationDelay <= 0) {
				SharkAttackTimer = (Random.Range (3, 10) + Time.time);
			}
		} else {
			SharkoMove.Play ("SharkMoving");
			print ("In State: Moving");
		}
	}
}
