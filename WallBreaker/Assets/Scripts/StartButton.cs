using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public void OnClickStart() {
		SceneManager.LoadScene ("Main");
	}

	public void OnClickOptions() {
		SceneManager.LoadScene ("Options Menu");
	}

	public void OnClickMenu() {
		SceneManager.LoadScene ("Main Menu");
	}
}
