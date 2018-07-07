using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenScript : MonoBehaviour {

	[SerializeField]
	//ポーズした時に表示するUI
	private GameObject pauaseUI;
	//ポーズUIのインスタンス
	private GameObject instancePauseUI;

	//Update is called once per frame
	void Update (){
		if (Input.GetKeyDown ("h")) {
			if (instancePauseUI == null) {
				instancePauseUI = GameObject.Instantiate (pauaseUI) as GameObject;
				Time.timeScale = 0f;
			} else {
				Destroy(instancePauseUI);
				Time.timeScale = 1f;
			}
		}
	}
}
