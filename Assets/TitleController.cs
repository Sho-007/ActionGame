using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour {

	public Text highScoreLabel;

	public void Start(){
		//ハイスコアを表示
		highScoreLabel.text = "High Score : " + PlayerPrfs.GetInt("HighScore") + "m"
	}

	public void OnStartButtonClicked(){

		Application.LoadLevel("Main");
	}
}
