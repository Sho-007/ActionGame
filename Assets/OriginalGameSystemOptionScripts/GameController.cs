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

		//unitychanのライフが0になった場合はゲームオーバー
		if (player.Life() <= 0){
			//これ以降のUpdateは止める
			enabled = false;

			//ハイスコアの更新
			if(PlayerPrefs.GetInt("HighScore") < score){
				PlayerPrefs.SetInt("HighScore", score);
			}

			//2秒後にReturnToTitleを呼び出す
			Invoke("ReturnToTitle" , 2.0f);
		}

	}
	int CalcScore(){
		//unitychanの走行距離をスコアとする
		return (int)player.transform.position.z;
	}

	void ReturnToTitle(){
		//タイトルシーンに切り替え
		Application.LoadLevel("Title");
	}
}

