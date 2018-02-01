using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class PlayeLimits : MonoBehaviour {


	
	public GameObject Player;
	
	private Rigidbody rb;

	// Use this for initialization

	void Start () {

		
rb = Player.GetComponent<Rigidbody> ();
	}

	
// Update is called once per frame

	void Update () {

	
	Vector3 distanceFromRaft = transform.position - Player.transform.position;
	

	if(distanceFromRaft.x < 4 && distanceFromRaft.x > 0){
		
		rb.AddForce(distanceFromRaft.normalized * 10);		

	}
	if(distanceFromRaft.x < 0 && distanceFromRaft.x > -4){
		
		rb.AddForce(distanceFromRaft.normalized * 10);		

	}

	}

}
