using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {

	public GameObject Meteor;

	void Start() {
		for (int i = 0; i < 5; i++) {
			Instantiate(Meteor);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
