using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed;
	private Rigidbody2D rb;
	private delegate Vector2 DirectionFunction();
	private DirectionFunction getDirection;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		if (TiltOrTouch.isTilt) {
			getDirection = GetInputUsingTilt;
		} else {
			getDirection = GetInputUsingTouch;
		}
	}

	void FixedUpdate () {
		Vector2 direction = getDirection();
		if (direction.magnitude > 0.1f) {
			direction.Normalize ();
			rb.AddForce (direction * moveSpeed);
			Debug.Log (rb.velocity.magnitude);
		}
	}

	Vector2 GetInputUsingTilt() {
		mousePosition = Input.acceleration;
		return new Vector2 (mousePosition.x, mousePosition.y);
	}

	Vector2 GetInputUsingTouch() {
		if (Input.touchCount > 0) {
			Vector3 touchPos = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
			return new Vector2(touchPos.x, touchPos.y) - new Vector2 (transform.position.x, transform.position.y);
		} else {
			return new Vector2 (0, 0);
		}
	}
}
