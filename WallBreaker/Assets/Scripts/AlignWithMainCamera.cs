using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraEdge {Top, Bottom, Left, Right};

public class AlignWithMainCamera : MonoBehaviour {

	public CameraEdge cameraEdge;
	// Use this for initialization
	void Start () {
		float height = Camera.main.orthographicSize * 2;
		float width = height * Screen.width / Screen.height;
		//Debug.Log (width + " <- width || height -> " + height);
		switch (cameraEdge) {
		case CameraEdge.Top:
		case CameraEdge.Bottom:
			transform.localScale = new Vector2 (width, 1);
			break;
		case CameraEdge.Left:
		case CameraEdge.Right:
			transform.localScale = new Vector2 (1, height);
			break;
		}
		float topY = height / 2 + transform.localScale.y / 2;
		float leftX = -width / 2 - transform.localScale.x / 2;
		switch (cameraEdge) {
		case CameraEdge.Top:
			transform.position = new Vector2 (0, topY);
			break;
		case CameraEdge.Bottom:
			transform.position = new Vector2 (0, -topY);
			break;
		case CameraEdge.Left:
			transform.position = new Vector2 (leftX, 0);
			break;
		case CameraEdge.Right:
			transform.position = new Vector2 (-leftX, 0);
			break;
		}
	}
}
