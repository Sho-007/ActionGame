using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenScript : MonoBehaviour {

	[SerializeField]
	//ポーズした時に表示するUI
	private GameObject pauaseUI;
	//ポーズUIのインスタンス
	private GameObject instancePauseUi;

	//Update is called once per frame
	void Update (){
		if (Input.GetKeyDown ("q")) {
			if (instancePauseUI == null) {
				instancePauseUI = GameObject.Instantiate (pauseUI) as GameObject;
				Time.timeScale = 0f;
			} else {
				Destroy (instancepauseUI);
				Time.timeScale = 1f;
			}
		}
	}
}
