using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientateScreen : MonoBehaviour {

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
}
