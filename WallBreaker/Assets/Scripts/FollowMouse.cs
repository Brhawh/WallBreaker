using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mousePosition = Input.acceleration;
		Vector2 direction = new Vector2(mousePosition.x, mousePosition.y);
		if (direction.magnitude > 0.1f) {
			direction.Normalize ();
			rb.AddForce (direction * moveSpeed);
			Debug.Log (rb.velocity.magnitude);
		}
	}
}
