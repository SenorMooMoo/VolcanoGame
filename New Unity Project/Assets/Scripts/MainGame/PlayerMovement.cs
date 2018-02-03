using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rb;

	public float addedForce;
	public float pushDown;

	public Transform raftTransform;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		pushDown = transform.position.y + 1;
	}

	// Update is called once per frame
	void Update () {

		rb.AddForce (raftTransform.forward * Mathf.Clamp (addedForce / rb.velocity.magnitude, -100, 100) * Input.acceleration.x);
		if(transform.position.y > pushDown){
			rb.AddForce (Vector3.up * addedForce * -2);
		}
	}
}
