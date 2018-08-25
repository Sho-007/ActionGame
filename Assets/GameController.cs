using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {
	public PlayerController player;
	//スコアラベルの参照
	public Text ScoreLabel;
	public LifePanel lifePanel;
	
	void Update () {
		//スコアラベルを更新
		int score = CalcScore();
		//テキストの更新
		ScoreLabel.text = "Score : " + score + "m";

		//ライフパネルを更新
		lifePanel.UpdateLife(player.Life());

	}
	int CalcScore(){
		//unitychanの走行距離をスコアとする
		return (int)player.transform.position.z;
	}
}

