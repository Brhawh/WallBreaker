using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiltOrTouch : MonoBehaviour {

	public static bool isTilt = true;
	Toggle tiltToggle;

	void Start() {
		tiltToggle = GetComponent<Toggle> ();
		tiltToggle.onValueChanged.AddListener (delegate {
			ToggleInputControl(tiltToggle);
		});
	}

	void ToggleInputControl(Toggle toggle) {
		isTilt = !isTilt;
	}
}
