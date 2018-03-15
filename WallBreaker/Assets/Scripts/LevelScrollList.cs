using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item {
	public string itemName;
}

public class LevelScrollList : MonoBehaviour {

	public List<Item> itemList;
	public Transform contentPanel;
	public SimpleObjectPool buttonObjectPool;

	// Use this for initialization
	void Start () {
		RefreshDisplay ();
	}

	public void RefreshDisplay() {
		AddButtons ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void AddButtons() {
		for (int i = 0; i < itemList.Count; i++) {
			Item item = itemList [i];
			GameObject newButton = buttonObjectPool.GetObject ();
			newButton.transform.SetParent (contentPanel);

			LevelSelectButton levelButton = newButton.GetComponent<LevelSelectButton> ();
			levelButton.SetUp (item, this);
		}
	}
}
