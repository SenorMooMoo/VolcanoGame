using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rb;

	public float addedForce;
	public float pushDown;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (Vector3.right * addedForce * Input.acceleration.x);
		if(transform.position.y > pushDown){
			rb.AddForce (Vector3.up * -100);
		}
	}
}
