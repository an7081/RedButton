﻿using UnityEngine;
using System.Collections;

public class killZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		Destroy(other.gameObject);

		if(other.gameObject.tag == "Player"){
			//reset code
		}
	}
}
