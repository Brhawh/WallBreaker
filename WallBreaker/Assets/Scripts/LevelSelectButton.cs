using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectButton : MonoBehaviour {

	public Button button;
	public Text levelNameLabel;

	private Item item;
	private LevelScrollList scrollList;

	// Use this for initialization
	void Start () {
		
	}
	
	public void SetUp(Item currentItem, LevelScrollList currentList){
		Debug.Log (currentItem);
		Debug.Log (currentList);
		item = currentItem;
		levelNameLabel.text = currentItem.itemName;

		scrollList = currentList;
	}
}
