using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Restart : MonoBehaviour {

		// ★（追加）
		// 先頭に「public」をつけること（ポイント）
		public void OnRestartButtonClicked(){
			SceneManager.LoadScene ("Main");
		}
	}