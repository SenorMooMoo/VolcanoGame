using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class FollowRaft : MonoBehaviour {


	public GameObject Follow;


	// Use this for initialization
	
	void Start () {
	
	
	
}
	
	
// Update is called once per frame

	void Update () {

		 Vector3 eulerRotation = new Vector3(transform.eulerAngles.x, Follow.transform.eulerAngles.y, transform.eulerAngles.z);
 
		 transform.localRotation = Quaternion.Euler(eulerRotation);

	}

}

