using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blur : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.mainTexture.mipMapBias = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
