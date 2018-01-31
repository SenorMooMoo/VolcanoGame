using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {

	public GameObject Meteor;
	private float delay;
	public float delayTime;


	void Start() {
		delay = 2;
	}
	
	// Update is called once per frame
	void Update () {
		

		if (delay <= Time.time) {
			GameObject meteor = (GameObject)Instantiate (Meteor, new Vector3 (Random.Range (transform.position.x-5, transform.position.x+5), transform.position.y, transform.position.z), Quaternion.identity);
			meteor.transform.SetParent(gameObject.transform);
			delay = delayTime + Time.time;
		}
	}
}
