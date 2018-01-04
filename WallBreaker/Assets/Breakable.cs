﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

	public float breakingVelocityMagnitude;

	void OnCollisionEnter2D(Collision2D coll) {
		print (coll.relativeVelocity.magnitude);
		if (coll.relativeVelocity.magnitude > breakingVelocityMagnitude) {
			GameObject.Destroy (gameObject);
		}
	}
}